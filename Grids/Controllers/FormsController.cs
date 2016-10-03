using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.WebSockets;
using Grids.Models;

namespace Grids.Controllers
{
    public class FormsController : ApiController
    {
        public FormsController()
        {
        }

        [System.Web.Http.HttpGet]
        public IEnumerable<FormData> GetFormData(int policyClassId, int policyTypeId, int carrierId, int stateId)
        {
            List<FormData> formDataList = new List<FormData>(256);

            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder() { DataSource = "ENIAC", InitialCatalog = "Navigate_NPR", IntegratedSecurity = true };

            using (SqlConnection sqlConnection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
            {

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [vw_FormData] WHERE [PolicyClassId] = @PolicyClassId AND ( [PolicyTypeId] =  @PolicyTypeId OR [PolicyTypeId] IS NULL ) AND ( [CarrierId] =  @CarrierId OR [CarrierId] IS NULL )AND ( [StateId] =  @StateId OR [StateId] IS NULL ); ", sqlConnection))
                {

                    sqlCommand.Parameters.AddWithValue("@PolicyClassId", policyClassId);
                    sqlCommand.Parameters.AddWithValue("@PolicyTypeId", policyTypeId);
                    sqlCommand.Parameters.AddWithValue("@CarrierId", carrierId);
                    sqlCommand.Parameters.AddWithValue("@StateId", stateId);

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {

                        while (sqlDataReader.Read())
                        {

                            formDataList.Add(

                                new FormData()
                                {
                                    FormFamilyId = sqlDataReader.GetString(sqlDataReader.GetOrdinal("FormFamilyId")),
                                    FormFamilyName = sqlDataReader.GetString(sqlDataReader.GetOrdinal("FormFamilyName")),
                                    PolicyClassId = sqlDataReader.GetString(sqlDataReader.GetOrdinal("PolicyClassId")),
                                    FormDefinitionId = sqlDataReader.GetString(sqlDataReader.GetOrdinal("FormDefinitionId")),
                                    DocumentTypeId = sqlDataReader.GetString(sqlDataReader.GetOrdinal("DocumentTypeId")),
                                    Name = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Name")),
                                    Description_FD = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Description_FD")),
                                    BaseFormIdString = sqlDataReader.GetString(sqlDataReader.GetOrdinal("BaseFormIdString")),
                                    IsPremiumBearing = sqlDataReader.GetString(sqlDataReader.GetOrdinal("IsPremiumBearing")),
                                    FormClassId = sqlDataReader.GetString(sqlDataReader.GetOrdinal("FormClassId")),
                                    OrderWithinClass = sqlDataReader.GetString(sqlDataReader.GetOrdinal("OrderWithinClass")),
                                    WatermarkOnQuote = sqlDataReader.GetString(sqlDataReader.GetOrdinal("WatermarkOnQuote")),
                                    WatermarkOnBinder = sqlDataReader.GetString(sqlDataReader.GetOrdinal("WatermarkOnBinder")),
                                    WatermarkOnPolicy = sqlDataReader.GetString(sqlDataReader.GetOrdinal("WatermarkOnPolicy")),
                                    WatermarkOnEndorsement = sqlDataReader.GetString(sqlDataReader.GetOrdinal("WatermarkOnEndorsement")),
                                    IncludeTermsOnQB = sqlDataReader.GetString(sqlDataReader.GetOrdinal("IncludeTermsOnQB")),
                                    IncludeTermsOnDecPage = sqlDataReader.GetString(sqlDataReader.GetOrdinal("IncludeTermsOnDecPage")),
                                    FormEditionIdToSelect = sqlDataReader.GetString(sqlDataReader.GetOrdinal("FormEditionIdToSelect")),
                                    Active_FD = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Active_FD")),
                                    FormEditionId = sqlDataReader.GetString(sqlDataReader.GetOrdinal("FormEditionId")),
                                    FormIdString = sqlDataReader.GetString(sqlDataReader.GetOrdinal("FormIdString")),
                                    EditionDate = sqlDataReader.GetString(sqlDataReader.GetOrdinal("EditionDate")),
                                    AdobeId = sqlDataReader.GetString(sqlDataReader.GetOrdinal("AdobeId")),
                                    ShortName = sqlDataReader.GetString(sqlDataReader.GetOrdinal("ShortName")),
                                    HasUserFillIns = sqlDataReader.GetString(sqlDataReader.GetOrdinal("HasUserFillIns")),
                                    ParticipateInEndorsementNumbering = sqlDataReader.GetString(sqlDataReader.GetOrdinal("ParticipateInEndorsementNumbering")),
                                    DefaultComment = sqlDataReader.GetString(sqlDataReader.GetOrdinal("DefaultComment")),
                                    Active_FE = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Active_FE")),
                                    SubjectivityFormEditionId = sqlDataReader.GetString(sqlDataReader.GetOrdinal("SubjectivityFormEditionId")),
                                    SubjectivityDefaultText = sqlDataReader.GetString(sqlDataReader.GetOrdinal("SubjectivityDefaultText")),
                                    FormDefaultComment = sqlDataReader.GetString(sqlDataReader.GetOrdinal("FormDefaultComment")),
                                    FormFilingId = sqlDataReader.GetString(sqlDataReader.GetOrdinal("FormFilingId")),
                                    CarrierId = sqlDataReader.GetString(sqlDataReader.GetOrdinal("CarrierId")),
                                    CountryId = sqlDataReader.GetString(sqlDataReader.GetOrdinal("CountryId")),
                                    StateId = sqlDataReader.GetString(sqlDataReader.GetOrdinal("StateId")),
                                    PolicyTypeId = sqlDataReader.GetString(sqlDataReader.GetOrdinal("PolicyTypeId")),
                                    FormBehaviorId = sqlDataReader.GetString(sqlDataReader.GetOrdinal("FormBehaviorId")),
                                    CanHaveMultiples = sqlDataReader.GetString(sqlDataReader.GetOrdinal("CanHaveMultiples")),
                                    AppliesToSubmission = sqlDataReader.GetString(sqlDataReader.GetOrdinal("AppliesToSubmission")),
                                    AppliesToQuote = sqlDataReader.GetString(sqlDataReader.GetOrdinal("AppliesToQuote")),
                                    AppliesToBinder = sqlDataReader.GetString(sqlDataReader.GetOrdinal("AppliesToBinder")),
                                    AppliesToPolicy = sqlDataReader.GetString(sqlDataReader.GetOrdinal("AppliesToPolicy")),
                                    AppliesToEndorsement = sqlDataReader.GetString(sqlDataReader.GetOrdinal("AppliesToEndorsement")),
                                    AppliesToCancellation = sqlDataReader.GetString(sqlDataReader.GetOrdinal("AppliesToCancellation")),
                                    ClaimsMade = sqlDataReader.GetString(sqlDataReader.GetOrdinal("ClaimsMade")),
                                    RetainUserFillIns = sqlDataReader.GetString(sqlDataReader.GetOrdinal("RetainUserFillIns")),
                                    IncludeDataOnQuote = sqlDataReader.GetString(sqlDataReader.GetOrdinal("IncludeDataOnQuote")),
                                    IncludeDataOnBinder = sqlDataReader.GetString(sqlDataReader.GetOrdinal("IncludeDataOnBinder")),
                                    IncludeDataOnPolicy = sqlDataReader.GetString(sqlDataReader.GetOrdinal("IncludeDataOnPolicy")),
                                    IncludeDataOnEndorsement = sqlDataReader.GetString(sqlDataReader.GetOrdinal("IncludeDataOnEndorsement")),
                                    FormCustomRuleId = sqlDataReader.GetString(sqlDataReader.GetOrdinal("FormCustomRuleId")),
                                    Description_FCR = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Description_FCR")),
                                    XPathRule = sqlDataReader.GetString(sqlDataReader.GetOrdinal("XPathRule")),
                                    FormFilingHistoryId = sqlDataReader.GetString(sqlDataReader.GetOrdinal("FormFilingHistoryId")),
                                    ModificationDate = sqlDataReader.GetString(sqlDataReader.GetOrdinal("ModificationDate")),
                                    EffectiveDate = sqlDataReader.GetString(sqlDataReader.GetOrdinal("EffectiveDate")),
                                    ExpiryDate = sqlDataReader.GetString(sqlDataReader.GetOrdinal("ExpiryDate")),
                                    FormMasterRow = sqlDataReader.GetString(sqlDataReader.GetOrdinal("FormMasterRow")),
                                });

                        }

                    }

                }

                sqlConnection.Close();

            }

            return formDataList;
        }
    }
}
