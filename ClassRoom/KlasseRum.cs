﻿using System;
using System.Collections.Generic;

namespace ClassRoom
{
    public class KlasseRum
    {
        public string KlasseNavn { get; set; }
        public List<Studerende> Klasseliste { get; set; }
        public DateTime SemesterStart { get; set; }

        public KlasseRum()
        {
            Klasseliste = new List<Studerende>();   
        }
    }
}