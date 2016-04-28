﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ScholarshipWebApplication.Models.Database
{
    public enum SocialScholarshipKind
    {
        normalne,
        zwiększone_akademik,
        zwiększone_inne
    }
    public class SocialScholarshipProps
    {
        [Key]
        public int DocID { get; set; }
        [DisplayName("Rodzaj")]
        public SocialScholarshipKind kind { get; set; }
        [DisplayName("Przychód roczny")]
        public string incomeYear { get; set; } //rok kalendarzowy dochodow
        [DisplayName("Przychód Netto")]
        public float netIncome { get; set; } //dochód netto
        [DisplayName("Dochód utracony")]
        public float lostIncome { get; set; }
        [DisplayName("Dochód uzyskany")]
        public float gainedIncome { get; set; }
        [DisplayName("Dochód rodzinny netto na osobę")]
        public float incomePerPersonPerMonth { get; set; }
        [DisplayName("Odliczenie z tytułu alimentów")]
        public float alimonyCuts { get; set; } //odliczenia z tytułu płacenia alimentów
        public string bankAccountNmb { get; set; }
        public DocState docState { get; set; }
        public virtual Student student { get; set; }
        public virtual IList<FamilyMembersIncome> familyMembersIncome { get; set; }
    }
}
