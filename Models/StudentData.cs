﻿using System;
using System.ComponentModel.DataAnnotations;

namespace StudentsDataApi.Models
{
    public class StudentData
    {
        [Required(ErrorMessage = "Field Id is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Field name is required")]
        [StringLength(50, ErrorMessage = "Max 50 characters allowed")]
        [RegularExpression(@"^[A-ZĘÓĄŚŁŻŹĆŃ]+[a-zęóąśłżźćńA-ZĘÓĄŚŁŻŹĆŃ ]*$",
        ErrorMessage = "Name must start with uppercase letter and contain only letters")]
        public string name { get; set; }

        [Required(ErrorMessage = "Field surname is required")]
        [StringLength(50, ErrorMessage = "Max 50 characters allowed")]
        [RegularExpression(@"^[A-ZŻŹĆĄŚĘŁÓŃ]+[a-zżźćńółęąś]+[ \-]?[a-zęóąśłżźćńA-ZĘÓĄŚŁŻŹĆŃ ]*$",
        ErrorMessage = "Surname must start with uppercase letter and contain only letters or dash")]
        public string surname { get; set; }

        [Required(ErrorMessage = "Field indexNumber is required")]
        [Range(100000, 999999)]
        public int indexNumber { get; set; }

        [Required(ErrorMessage = "Field pesel is required")]
        [StringLength(11, ErrorMessage = "Only 11 digits allowed")]
        [RegularExpression(@"^[0-9]{11}$",
        ErrorMessage = "PESEL must contain only 11 digits")]
        public string pesel { get; set; }

        [Required(ErrorMessage = "Field email is required")]
        [StringLength(320, ErrorMessage = "Max 320 characters allowed")]
        [RegularExpression(@"[a-z0-9!#$%&'\*\\\\+\\/=?^`{}|]{1}[a-z0-9!#$%&'\*\.\\\+\-\/=?^_`{}|]+@[a-z0-9.-]+\.[a-z]{2,4}$",
        ErrorMessage = "Email must contain only lowercase letters, @ and .")]
        public string email { get; set; }

        [Required(ErrorMessage = "Field studiesType is required")]
        [StringLength(20, ErrorMessage = "Max 20 characters allowed")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Studies type must contain only letters")]
        public string studiesType { get; set; }

        [Required(ErrorMessage = "Field degree is required")]
        [StringLength(3, ErrorMessage = "Max 3 characters allowed")]
        [RegularExpression(@"^[I]{1,3}$", ErrorMessage = "Allowed values of degree: I, II, III")]
        public string degree { get; set; }


        [Required(ErrorMessage = "Field fieldOfStudy is required")]
        [StringLength(50, ErrorMessage = "Max 50 characters allowed")]
        [RegularExpression(@"^[A-ZĘÓĄŚŁŻŹĆŃ]+[a-zęóąśłżźćńA-ZĘÓĄŚŁŻŹĆŃ \-]*$",
        ErrorMessage = " FieldOfStudy must start with uppercase letter and must not contain special characters (except of dash)")]
        public string fieldOfStudy { get; set; }

        [Required(ErrorMessage = "Field specialization is required")]
        [StringLength(50, ErrorMessage = "Max 50 characters allowed")]
        [RegularExpression(@"^[A-ZĘÓĄŚŁŻŹĆŃa-zęóąśłżźćń \-]*$",
        ErrorMessage = "Only letters and dashes allowed")]
        public string specialization { get; set; }

        public DateTime dateNow = DateTime.Now;
        public DateTime dateModified
        {
            get { return dateNow; }
            set { dateNow = value; }
        }
    }
}
