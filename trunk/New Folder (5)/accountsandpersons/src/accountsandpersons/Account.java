/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package accountsandpersons;

import java.text.DecimalFormat;
import javax.swing.JOptionPane;
import java.util.*;


/**
 *
 * @author jpj5048
 */
public class Account {
    static String accountNum;
    static double balance;
    static Person owner;
    static int freeTransCharge;
    double charge = 0.30;
    static int resetted = 0;
    Calendar cal = Calendar.getInstance();



    public Account(){
        FileReader jj = new FileReader();
        jj.readfile();
        
        accountNum = FileReader.a;
        freeTransCharge = FileReader.convertD;



        balance = Double.parseDouble(FileReader.b);

        owner = new Person();
      }
    

   public void deposit(){
         String depositString = JOptionPane.showInputDialog("Amount of deposit = ");
        double depositAmt = Double.parseDouble(depositString);
        //double depositcharge = 0.30;
        if (depositAmt >= 0.01)
       //balance -= depositcharge;
       balance += depositAmt;
       freeTransCharge--;
       


        DecimalFormat balanceformat = new DecimalFormat("0.00");
        JOptionPane.showMessageDialog(null, "New balance = " + balanceformat.format(balance));

    }

    public void withdrawl(){
         String withdrawlString = JOptionPane.showInputDialog("Amount of withdrawl = ");
         //double withdrawlCharge = 0.30;
        // balance -= withdrawlCharge;
        double withdrawlAmt = Double.parseDouble(withdrawlString);
       
        DecimalFormat balanceformat = new DecimalFormat("0.00");

        if (withdrawlAmt <= balance) {
        balance -= withdrawlAmt;
        freeTransCharge--;
        


        JOptionPane.showMessageDialog(null, "New balance = " + balanceformat.format(balance));
       }
        else
           JOptionPane.showMessageDialog(null, "Balance = " +  balanceformat.format(balance)  + '\n'
                   + "Desired amount could not be withdrawn");
    }

    public void monthRestCharge(){
        //int day = cal.get(Calendar.DAY_OF_MONTH);

        int day = 1;

        if (day == 1 && resetted == 0) {
            if (freeTransCharge <= 0)
                balance -= charge*Math.abs(freeTransCharge);
            freeTransCharge = 10;
            resetted = 1;
        }
        else if (day >= 1 && day <= 31) {
            resetted = 0;
        }


    }

    public void display(){

         monthRestCharge();
         
        FileMaker g = new FileMaker();
        g.openFile();
        g.addRecords();
        g.closeFile();
        
        DecimalFormat balanceformat = new DecimalFormat("0.00");
        JOptionPane.showMessageDialog(null,"Account number  = " + accountNum + '\n'
               + "Balance = " + balanceformat.format(balance) + '\n'
               +  "Owner name = " + owner.getName()+ '\n'
               + "Charges = " + freeTransCharge);





    }

    /* public void save(){
       try {
           x = new Formater("someFile.txt");
           System.out.println("you created a file");*/

           /*File someFile = new File("C:/fileName.txt");
        FileWriter writer = new FileWriter(someFile, true);
        writer.write*/
      /* } catch(Exception e)
       {
           System.out.println("you got an error");
       }*/

    }




