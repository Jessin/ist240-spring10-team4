/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package accountsandpersons;

import java.io.*;
import java.lang.*;
import java.util.*;


/**
 *
 * @author J & J
 */
public class FileReader {

    private Scanner x;
   static String a;
    static String b;
   static String c;
    static String d;
    static String f;
    static int convertD;
    static int convertF;




   



    /*public void openfile(){
        


    }*/

    public void readfile(){
        try{
            x = new Scanner(new File("banksaving.txt"));

        } catch (Exception e){
            System.out.println("could not find the stupid file");
        }
        int Count1 =0;
        while(x.hasNext()){
           
           if (Count1 <1){
                 a = x.next();
           }
           else if (Count1 <2){
                 b = x.next();
           }
           else if (Count1 <3){
                 c = x.next();
           }
           else if (Count1 <4){
                 d = x.next();
                 convertD = Integer.parseInt(d);
           }
           else {
               f = x.next();
               convertD = Integer.parseInt(f);
           }


          Count1++;
        }

        if(Integer.parseInt(d) >= 0){
            System.out.printf("%s %s %s %s %s\n", "account Number =" +a,"balance = " +b,"Owner name =" +c, "Charges reaming =" +d, "T/F" + f);}
        else System.out.printf("%s %s %s %s %s\n", "account Number =" +a,"balance = " +b,"Owner name =" +c, "You have gone below your free charges =" +d, "T/F" + f);



        }
    }

     /*Account.accountNum = a;
            Account.balance = Double.parseDouble(b);
            Person.name = c;
            Account.freeTransCharge = Integer.parseInt(d);*/

    /*public void closereadfile(){
        x.close();
    }

}*/
