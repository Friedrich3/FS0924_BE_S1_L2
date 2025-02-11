namespace FS0924_BE_S1_L2.Models
{
    internal class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Eta {  get; set; }
        //COSTUTTORI PRIMA DEI METODI

        public Persona(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = "Non Specificata";

        }
        public Persona(string nome, string cognome, int eta) 
        { 
            Nome=nome;
            Cognome = cognome;
            Eta = eta.ToString();
        }
        
        public string GetNome()
        {
            return Nome;
        }
        public string GetCognome()
        {
            return Cognome;
        }
        public string GetEta()
        {
            return Eta.ToString();
        }

        public string GetDettagli()
        {
            return $"Nome:{Nome}, Cognome:{Cognome}, Eta': {Eta}";
        }
    }
}
