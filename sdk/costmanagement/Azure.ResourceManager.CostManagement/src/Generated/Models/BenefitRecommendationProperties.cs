// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary>
    /// The properties of the benefit recommendations.
    /// Please note <see cref="BenefitRecommendationProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SharedScopeBenefitRecommendationProperties"/> and <see cref="SingleScopeBenefitRecommendationProperties"/>.
    /// </summary>
    public abstract partial class BenefitRecommendationProperties
    {
        /// <summary> Initializes a new instance of BenefitRecommendationProperties. </summary>
        protected BenefitRecommendationProperties()
        {
        }

        /// <summary> Initializes a new instance of BenefitRecommendationProperties. </summary>
        /// <param name="firstConsumptionOn"> The first usage date used for looking back for computing the recommendations. </param>
        /// <param name="lastConsumptionOn"> The last usage date used for looking back for computing the recommendations. </param>
        /// <param name="lookBackPeriod"> The number of days of usage evaluated for computing the recommendations. </param>
        /// <param name="totalHours"> The total hours for which the cost is covered. Its equal to number of records in a property &apos;properties/usage/charges&apos;. </param>
        /// <param name="usage"> On-demand charges between firstConsumptionDate and lastConsumptionDate that were used for computing benefit recommendations. </param>
        /// <param name="armSkuName"> ARM SKU name. &apos;Compute_Savings_Plan&apos; for SavingsPlan. </param>
        /// <param name="term"> Term period of the benefit. For example, P1Y or P3Y. </param>
        /// <param name="commitmentGranularity"> Grain of the proposed commitment amount. Supported values: &apos;Hourly&apos;. </param>
        /// <param name="currencyCode"> An ISO 4217 currency code identifier for the costs and savings amounts. </param>
        /// <param name="costWithoutBenefit"> The current cost without benefit, corresponds to &apos;totalHours&apos; in the look-back period. </param>
        /// <param name="recommendationDetails"> The details of the proposed recommendation. </param>
        /// <param name="allRecommendationDetails"> The list of all benefit recommendations with the recommendation details. </param>
        /// <param name="scope"> Benefit scope. For example, Single or Shared. </param>
        internal BenefitRecommendationProperties(DateTimeOffset? firstConsumptionOn, DateTimeOffset? lastConsumptionOn, LookBackPeriod? lookBackPeriod, int? totalHours, RecommendationUsageDetails usage, string armSkuName, BenefitRecommendationPeriodTerm? term, BenefitRecommendationUsageGrain? commitmentGranularity, string currencyCode, decimal? costWithoutBenefit, AllSavingsBenefitDetails recommendationDetails, AllSavingsList allRecommendationDetails, BenefitRecommendationScope scope)
        {
            FirstConsumptionOn = firstConsumptionOn;
            LastConsumptionOn = lastConsumptionOn;
            LookBackPeriod = lookBackPeriod;
            TotalHours = totalHours;
            Usage = usage;
            ArmSkuName = armSkuName;
            Term = term;
            CommitmentGranularity = commitmentGranularity;
            CurrencyCode = currencyCode;
            CostWithoutBenefit = costWithoutBenefit;
            RecommendationDetails = recommendationDetails;
            AllRecommendationDetails = allRecommendationDetails;
            Scope = scope;
        }

        /// <summary> The first usage date used for looking back for computing the recommendations. </summary>
        public DateTimeOffset? FirstConsumptionOn { get; }
        /// <summary> The last usage date used for looking back for computing the recommendations. </summary>
        public DateTimeOffset? LastConsumptionOn { get; }
        /// <summary> The number of days of usage evaluated for computing the recommendations. </summary>
        public LookBackPeriod? LookBackPeriod { get; set; }
        /// <summary> The total hours for which the cost is covered. Its equal to number of records in a property &apos;properties/usage/charges&apos;. </summary>
        public int? TotalHours { get; }
        /// <summary> On-demand charges between firstConsumptionDate and lastConsumptionDate that were used for computing benefit recommendations. </summary>
        public RecommendationUsageDetails Usage { get; set; }
        /// <summary> ARM SKU name. &apos;Compute_Savings_Plan&apos; for SavingsPlan. </summary>
        public string ArmSkuName { get; }
        /// <summary> Term period of the benefit. For example, P1Y or P3Y. </summary>
        public BenefitRecommendationPeriodTerm? Term { get; set; }
        /// <summary> Grain of the proposed commitment amount. Supported values: &apos;Hourly&apos;. </summary>
        public BenefitRecommendationUsageGrain? CommitmentGranularity { get; set; }
        /// <summary> An ISO 4217 currency code identifier for the costs and savings amounts. </summary>
        public string CurrencyCode { get; }
        /// <summary> The current cost without benefit, corresponds to &apos;totalHours&apos; in the look-back period. </summary>
        public decimal? CostWithoutBenefit { get; }
        /// <summary> The details of the proposed recommendation. </summary>
        public AllSavingsBenefitDetails RecommendationDetails { get; set; }
        /// <summary> The list of all benefit recommendations with the recommendation details. </summary>
        public AllSavingsList AllRecommendationDetails { get; }
        /// <summary> Benefit scope. For example, Single or Shared. </summary>
        internal BenefitRecommendationScope Scope { get; set; }
    }
}
