﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingService.DAL.Entities
{
    public class Video : BaseEntity
    {
        public string Name { get; set; }
        public string VideoSize { get; set; }     
        public string FilePath { get; set; }
        public DateTime UploadVideo { get; set; }

    }
}
