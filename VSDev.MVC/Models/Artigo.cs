﻿using System;

namespace VSDev.MVC.Models
{
    public class Artigo
    {
        public int IdArtigo { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataPublicacao { get; set; }
    }
}
