using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Metadata.Query;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MscrmTools.TimelineConfigurationReplicator.AppCode
{
    public static class MetadataManager
    {
        /// <summary>
        /// Recupere la liste des EntityMetadata presente dans la CRM
        /// </summary>
        /// <param name="service">CRM Service</param>
        /// <param name="solutionIds"></param>
        /// <param name="majorVersion"></param>
        /// <returns>Liste des entites retrouvees</returns>
        public static List<EntityMetadata> GetEntitiesList(IOrganizationService service, Guid solutionId)
        {
            if (solutionId != Guid.Empty)
            {
                var query = new QueryExpression("solutioncomponent")
                {
                    NoLock = true,
                    ColumnSet = new ColumnSet(true),
                    Criteria = new FilterExpression
                    {
                        Conditions =
                        {
                            new ConditionExpression("solutionid", ConditionOperator.Equal, solutionId),
                            new ConditionExpression("componenttype", ConditionOperator.Equal, 1)
                        }
                    }
                };

                var components = service.RetrieveMultiple(query).Entities;

                var list = components.Select(component => component.GetAttributeValue<Guid>("objectid"))
                    .ToList();

                if (list.Count > 0)
                {
                    EntityQueryExpression entityQueryExpression = new EntityQueryExpression()
                    {
                        Criteria = new MetadataFilterExpression
                        {
                            Conditions =
                            {
                                new MetadataConditionExpression("MetadataId", MetadataConditionOperator.In, list.ToArray()),
                                new MetadataConditionExpression("IsIntersect", MetadataConditionOperator.Equals, false)
                            }
                        },
                        Properties = new MetadataPropertiesExpression
                        {
                            AllProperties = false,
                            PropertyNames =
                            {
                                "DisplayName",
                                "LogicalName",
                                "SchemaName"
                            }
                        }
                    };

                    RetrieveMetadataChangesRequest retrieveMetadataChangesRequest = new RetrieveMetadataChangesRequest
                    {
                        Query = entityQueryExpression,
                        ClientVersionStamp = null
                    };

                    var response = (RetrieveMetadataChangesResponse)service.Execute(retrieveMetadataChangesRequest);

                    return response.EntityMetadata.ToList();
                }

                return new List<EntityMetadata>();
            }

            EntityQueryExpression entityQueryExpressionFull = new EntityQueryExpression()
            {
                Criteria = new MetadataFilterExpression
                {
                    Conditions =
                            {
                                new MetadataConditionExpression("IsIntersect", MetadataConditionOperator.Equals, false)
                            }
                },
                Properties = new MetadataPropertiesExpression
                {
                    AllProperties = false,
                    PropertyNames = { "DisplayName", "LogicalName", "SchemaName" }
                }
            };

            RetrieveMetadataChangesRequest request = new RetrieveMetadataChangesRequest
            {
                Query = entityQueryExpressionFull,
                ClientVersionStamp = null
            };

            var fullResponse = (RetrieveMetadataChangesResponse)service.Execute(request);

            return fullResponse.EntityMetadata.Where(e => e.DisplayName?.UserLocalizedLabel != null).ToList();
        }

        internal static void PublishEntities(List<string> entities, IOrganizationService service)
        {
            string parameterXml = string.Format("<importexportxml><entities>{0}</entities></importexportxml>",
                                                string.Join("", entities.Select(e => "<entity>" + e + "</entity>")));

            var publishRequest = new PublishXmlRequest { ParameterXml = parameterXml };
            service.Execute(publishRequest);
        }
    }
}