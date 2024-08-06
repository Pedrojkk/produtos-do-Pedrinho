namespace cliente.Models{

    class Cliente{

        public int Id { get; set; }
        public string Nome{ get; set; } = "";
        public string Cpf {get; set; } = "";
        public string Endereço {get; set;} = "";
        public string Telefone { get; set; } = "";
        public string Email { get; set; } = "";

    }


}