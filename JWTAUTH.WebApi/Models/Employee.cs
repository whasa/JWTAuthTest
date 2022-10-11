﻿using System;
using System.Collections.Generic;

namespace JWTAUTH.WebApi.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string NationalIdnumber { get; set; } = null!;
        public string? EmployeeName { get; set; }
        public string LoginId { get; set; } = null!;
        public string JobTitle { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public DateTime HireDate { get; set; }
        public short VacationHours { get; set; }
        public short SickLeaveHours { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
