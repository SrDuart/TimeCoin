﻿using System;
using System.Runtime.Serialization;

namespace Biblioteca.ClassesBasicas
{
    [DataContract]
    public class Usuario
    {
        [DataMember(IsRequired = true)]
        public int id { get; set; }
        [DataMember(IsRequired = true)]
        public TipoUsuario tipoUsuario { get; set; }
        [DataMember(IsRequired = true)]
        public Situacao situacao { get; set; }
        [DataMember(IsRequired = true)]
        public string nome { get; set; }
        [DataMember(IsRequired = true)]
        public string userName { get; set; }
        [DataMember(IsRequired = true)]
        public string cpf_cnpj { get; set; }
        [DataMember(IsRequired = true)]
        public string telefoneFixo { get; set; }
        [DataMember(IsRequired = true)]
        public string telefoneCelular { get; set; }
        [DataMember(IsRequired = true)]
        public string uf { get; set; }
        [DataMember(IsRequired = true)]
        public string cidade { get; set; }
        [DataMember(IsRequired = true)]
        public string bairro { get; set; }
        [DataMember(IsRequired = true)]
        public string email { get; set; }
        [DataMember(IsRequired = true)]
        public DateTime dataCadastro { get; set; }
        [DataMember(IsRequired = true)]
        public string senha { get; set; }
        [DataMember(IsRequired = true)]
        public int qtdHoraTrabalhada { get; set; }
        [DataMember(IsRequired = true)]
        public int qtdHoraDisponivel { get; set; }
        [DataMember(IsRequired = true)]
        public string descricao { get; set; }
	}
}
