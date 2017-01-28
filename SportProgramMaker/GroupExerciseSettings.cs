using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SportProgramMaker
{
    [DataContract]
    internal class GroupExerciseSettings
    {
        [DataMember]
        internal string name;

        [DataMember]
        internal List<string> items { get; set; }
    }
}
