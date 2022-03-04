namespace POO.classes.models
{
    public class Cliente
    {
        public Cliente(string password , float saldo)
        {
            this._password = password;
            this._saldo = saldo;
        }
        public string _name { get; private set; }
        public float _saldo { get; protected set; }
        public string _password { get; protected set; }
    }
}


