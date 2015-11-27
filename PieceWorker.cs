using System;

public class PieceWorker : Employee
{

    private decimal wage;
    private decimal pieceMade;

    public PieceWorker(string first, string last, string ssn, decimal hourlyWage, decimal piece)
        : base(first, last, ssn)
    {
        Wage = hourlyWage;
        pieceMade = piece;
    }

    public decimal Wage
    {
        get
        {
            return wage;
        }

        set
        {
            if (value >= 0) // validation
                wage = value;
            else
                throw new ArgumentOutOfRangeException("Wage",
                   value, "Wage must be >= 0");
        }
    }

    public decimal Piece
    {
        get
        {
            return pieceMade;
        }
    }//End Piece method
    public override decimal Earnings()
    {

        return (pieceMade * wage);
    }//End method Earnings                                      

   
    public override string ToString()
    {
        return string.Format(
           "hourly employee: {0}\n{1}: {2:C}; {3}: {4:F2}",
           base.ToString(), "hourly wage", Wage, "pieces made", Piece);
    }//End method ToString                                            
} //End class PieceWorker
