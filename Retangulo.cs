using System;

namespace Figuretas
{
    class Retangulo : Figura
    {
        public double Largura
        {

            get
            {
                return _largura;

            }

            set
            {
                if (value <= 0)
                {

                this._largura = value;
                this.AtualizarArea();
                this.AtualizarPerimetro();

                }

            }


        }





        private double _largura;
        public double Altura
        {

            get
            {
                return _altura;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Altura invalida");


                }

                else
                {
                    this._altura = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();

                }

            }


        }
        public Retangulo(double largura, double altura)
        {

            this._altura = altura;
            this._largura = largura;


        }

        private void AtualizarArea()
        {
            this._area = this._altura * this._largura;
        }

        private void AtualizarPerimetro()
        {

            this._perimetro = (this._altura + this._largura) * 2;

        }

        private double _altura;

    }


}

