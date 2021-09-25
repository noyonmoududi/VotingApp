using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VotingApp.Models
{
    public class AddToListModel
    {
        public string ImageText { get; set; }
        public byte[] ImageByte { get; set; }
        public string ImagePath { get; set; }
        public HttpPostedFileWrapper ImageFile { get; set; }
    }
}