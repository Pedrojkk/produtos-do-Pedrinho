namespace empresa.Models{

    class Empresa{

        public int Id { get; set; }
        public string Nome{ get; set; } = "";
        public string Endereço {get; set; } = "";
        public string Desconto {get; set;} = "";
        public string RegimeF { get; set; } = "";
        public string Cnpj { get; set; } = "";

    }


}