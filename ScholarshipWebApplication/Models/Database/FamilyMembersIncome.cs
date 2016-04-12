﻿using System.ComponentModel.DataAnnotations;

namespace ScholarshipWebApplication.Models.Database
{
    public class FamilyMembersIncome
    {
        public enum DegreeOfRelationship
        {
            ojciec, matka, siostra, brat
        }
        [Key]
        public string IncomeID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string birthdayYear { get; set; }
        public DegreeOfRelationship relationship { get; set; }
        public float taxedIncome { get; set; }
        public float untaxedIncome { get; set; }
        public float total { get; set; }
    }
}