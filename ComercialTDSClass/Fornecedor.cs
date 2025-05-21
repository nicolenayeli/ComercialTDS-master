using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    public class Fornecedor
    {
      
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string Fantasia { get; set; }
        public string Cnpj { get; set; }
        public string Contato { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public Fornecedor(int id, string razaoSocial, string fantasia, string cnpj, string contato, string telefone, string email)
        {
            Id = id;
            RazaoSocial = razaoSocial;
            Fantasia = fantasia;
            Cnpj = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }

        public Fornecedor(int id,  string cnpj)
        {
            Id = id;           
            Cnpj = cnpj;
           
        }
        public Fornecedor(int id, string razaoSocial, string fantasia, string cnpj, string contato, string telefone, string email)
        {
            Id = id;
            RazaoSocial = razaoSocial;
            Fantasia = fantasia;
            Cnpj = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }
    }





}
