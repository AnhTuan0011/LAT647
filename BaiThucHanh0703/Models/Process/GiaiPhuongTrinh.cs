namespace BAITHUCHANH0703.Models.Process
{
    public class GiaiPhuongTrinh{

    public string GiaiPhuongTrinhB1(double a , double b)
    {
        double x =-b/a;
        return "Nghiep cua phuong trinh x=" + x ;
    }
    
     public string GiaiPhuongTrinhB2(string hesoA, string hesoB, string hesoC)
        {
            //khai bao bien
            double delta, x1, x2, a =0, b=0, c=0;
            string ketqua;
            //Giai phuong trinh
            if(!String.IsNullOrEmpty(hesoA)) a = Convert.ToDouble(hesoA); 
            // neu he so a b c khong phai bang rong ,bang null thi se chuyen doi ve ToDouble
            if(!String.IsNullOrEmpty(hesoB)) b = Convert.ToDouble(hesoB);
            if(!String.IsNullOrEmpty(hesoC)) c = Convert.ToDouble(hesoC);
            if(a==0) ketqua = "Khong phai phuong trinh bac 2";
            else{
                //tinh delta
                delta = Math.Pow(b,2) - 4*a*c;
                // Giai phuong trinh
                if(delta<0) ketqua ="Phuong trinh vo nghiem";
                else if(delta==0)
                {
                    x1 = -b/(2*a);
                    ketqua ="Phuong trinh co nghiem kep = "+ x1;
                }
                else 
                {
                    x1= (-b + Math.Sqrt(delta))/(2*a);
                    x2= (-b - Math.Sqrt(delta))/(2*a);
                    ketqua = "Phuong trinh co 2 nghiem phan biet: x1= "+ x1 + ", x2= "+x2;
                }
            }
            return ketqua;
        }
    }
}