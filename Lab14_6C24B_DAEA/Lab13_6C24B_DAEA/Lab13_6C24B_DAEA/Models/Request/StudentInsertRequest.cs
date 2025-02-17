﻿using System.ComponentModel.DataAnnotations;

namespace Lab13_6C24B_DAEA.Models.Request
{
    public class StudentInsertRequest
    {
        [Key]
        public int GradeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
