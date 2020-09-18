

//using _05_ByteBank;

namespace _07_ByteBank 

{
    public class ContaCorrente
    {
       

        
        public Cliente Titular { get; set; }

        public static int TotaldeContasCriadas { get; private set; }


        private static int ObterTotaldeContasCriadas()
        {
            return TotaldeContasCriadas;
        }

        public int Agencia{ get; set; }

        public int Numero{ get; set; }
        private double _saldo = 100;

        public double Saldo 
        {
            get
            {
                return _saldo;
            }
            set
            {
                
                if (value < 0)
                {

                    return;

                }
                _saldo = value;
            }
        }  

        public ContaCorrente(int agencia, int numero) 
        {
            Agencia = agencia;
            Numero = numero;

            TotaldeContasCriadas++;

        }
        
        

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;

            }
            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }
    }


}

