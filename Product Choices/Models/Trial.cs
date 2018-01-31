using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product_Choices.Models
{
    public class Trial
    {
        public int Id { get; set; }

        public string ParticipantId { get; set; }

        public int TrialNumber { get; set; }

        public int ViewOption1Details { get; set; }

        public int ViewOption2Details { get; set; }

        public int OptionSelected { get; set; }

        public bool Completed { get; set; }
    }
}