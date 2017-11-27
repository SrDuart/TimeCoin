﻿using System;
using System.Runtime.Serialization;

namespace Biblioteca.ClassesBasicas
{
    [DataContract]
    [Serializable]
    public class TipoUsuario
	{
        [DataMember (IsRequired = true)]
        public int id { get; set; }
        [DataMember(IsRequired = true)]
        public string descricao { get; set; }
	}
}
