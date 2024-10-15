using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class TypeAdmissionDTO
    {
        public TypeOfDiploma TypeDiploma { get; set; }
        public TypeOfTranscript? TypeOfTranscript { get; set; }
    }
}
