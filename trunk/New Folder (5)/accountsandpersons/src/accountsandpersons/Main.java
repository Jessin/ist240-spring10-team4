/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package accountsandpersons;

import javax.swing.JOptionPane;
import java.text.SimpleDateFormat;

import java.util.Calendar;


/**
 *
 * @author jpj5048
 */
public class Main {

    /**
     * @param args the command line arguments
     */
    static Calendar cal;
    static SimpleDateFormat timenow;

    public static void main(String[] args) {



        Account anAcct = new Account();
        

        char choice = getUserChoice();
        while (choice != 'Q'){
            switch (choice){
                case 'D':anAcct.deposit();
                    break;
                case 'W':anAcct.withdrawl();
                    break;
                case 'S': anAcct.display();
                    break;

                default:


                }
             choice = getUserChoice();
            }
        }
    static char getUserChoice(){
        String userChoice = JOptionPane.showInputDialog("Choose: D: depost, W: withdrawl, S: Save Info, Q: quit");
        userChoice = userChoice.toUpperCase();

        
        
        
        
        return userChoice.charAt(0);



        
    }



}




