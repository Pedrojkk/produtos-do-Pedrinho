namespace produto.Models{

    class Produto{

        public int Id { get; set; }
        public string Nome{ get; set; } = "";
        public decimal Valor {get; set; }
        public string Cat {get; set;} = "";
        public string Desc { get; set; } = "";
        public string Status { get; set; } = "";
        public string Data { get; set; } = "";
        public string Responsavel { get; set; } = "";

    }


}