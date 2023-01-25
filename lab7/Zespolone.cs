using System;

namespace zespolone
{
    class Zespolona
{
    public double Re { get; set; }
    public double Im { get; set; }

    public Zespolona(double re, double im)
    {
        this.Re = re;
        this.Im = im;
    }

    public static Zespolona operator +(Zespolona c1, Zespolona c2)
    {
        return new Zespolona(c1.Re + c2.Re, c1.Im + c2.Im);
    }

    public static Zespolona operator -(Zespolona c1, Zespolona c2)
    {
        return new Zespolona(c1.Re - c2.Re, c1.Im - c2.Im);
    }

    public static Zespolona operator *(Zespolona c1, Zespolona c2)
    {
        return new Zespolona((c1.Re * c2.Re) - (c1.Im * c2.Im), (c1.Re * c2.Im) + (c1.Im * c2.Re));
    }

    public override string ToString()
    {
        return String.Format("({0} + {1}i)", Re, Im);
    }
}
}
