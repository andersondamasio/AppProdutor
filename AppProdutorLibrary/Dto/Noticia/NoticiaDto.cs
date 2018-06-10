using System;
using System.Collections.Generic;

namespace com.datacoper.appprodutor.Dto.Noticia
{

    public class Items
    {
        public List<NoticiaDto> items { get; set; } = new List<NoticiaDto>();
    }

    public class NoticiaDto
    {
        public String title { get; set; }

        public String content { get; set; }

        public DateTime pubDate { get; set; }

        public String author { get; set; }
    }
}
