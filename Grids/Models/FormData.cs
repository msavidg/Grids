using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grids.Models
{
    public class FormData
    {
        public string FormFamilyId { get; set; }
        public string FormFamilyName { get; set; }
        public string PolicyClassId { get; set; }
        public string FormDefinitionId { get; set; }
        public string DocumentTypeId { get; set; }
        public string Name { get; set; }
        public string Description_FD { get; set; }
        public string BaseFormIdString { get; set; }
        public string IsPremiumBearing { get; set; }
        public string FormClassId { get; set; }
        public string OrderWithinClass { get; set; }
        public string WatermarkOnQuote { get; set; }
        public string WatermarkOnBinder { get; set; }
        public string WatermarkOnPolicy { get; set; }
        public string WatermarkOnEndorsement { get; set; }
        public string IncludeTermsOnQB { get; set; }
        public string IncludeTermsOnDecPage { get; set; }
        public string FormEditionIdToSelect { get; set; }
        public string Active_FD { get; set; }
        public string FormEditionId { get; set; }
        public string FormIdString { get; set; }
        public string EditionDate { get; set; }
        public string AdobeId { get; set; }
        public string ShortName { get; set; }
        public string HasUserFillIns { get; set; }
        public string ParticipateInEndorsementNumbering { get; set; }
        public string DefaultComment { get; set; }
        public string Active_FE { get; set; }
        public string SubjectivityFormEditionId { get; set; }
        public string SubjectivityDefaultText { get; set; }
        public string FormDefaultComment { get; set; }
        public string FormFilingId { get; set; }
        public string CarrierId { get; set; }
        public string CountryId { get; set; }
        public string StateId { get; set; }
        public string PolicyTypeId { get; set; }
        public string FormBehaviorId { get; set; }
        public string CanHaveMultiples { get; set; }
        public string AppliesToSubmission { get; set; }
        public string AppliesToQuote { get; set; }
        public string AppliesToBinder { get; set; }
        public string AppliesToPolicy { get; set; }
        public string AppliesToEndorsement { get; set; }
        public string AppliesToCancellation { get; set; }
        public string ClaimsMade { get; set; }
        public string RetainUserFillIns { get; set; }
        public string IncludeDataOnQuote { get; set; }
        public string IncludeDataOnBinder { get; set; }
        public string IncludeDataOnPolicy { get; set; }
        public string IncludeDataOnEndorsement { get; set; }
        public string FormCustomRuleId { get; set; }
        public string Description_FCR { get; set; }
        public string XPathRule { get; set; }
        public string FormFilingHistoryId { get; set; }
        public string ModificationDate { get; set; }
        public string EffectiveDate { get; set; }
        public string ExpiryDate { get; set; }
        public string FormMasterRow { get; set; }
    }
}