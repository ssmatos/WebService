using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace WebServices.Models
{
    [DataContract]
    public class Genre
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "picture")]
        public string Picture { get; set; }

        [DataMember(Name = "picture_small")]
        public string PictureSmall { get; set; }

        [DataMember(Name = "picture_medium")]
        public string PictureMedium { get; set; }

        [DataMember(Name = "picture_big")]
        public string PictureBig { get; set; }

        [DataMember(Name = "picture_xl")]
        public string PictureXl { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }
    }
}
