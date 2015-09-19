/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package simpleserver;

/**
 *
 * @author Erni Kusrini
 */
import java.io.*;
import java.net.*;

public class SimpleServer {

    /**
     */
    public final static int TESTPORT = 5000;

    public static void main(String args[]) {
        // TODO code application logic here
        ServerSocket checkServer = null;
        String line;
        BufferedReader is = null;
        DataOutputStream os = null;
        Socket clientSocket = null;

        try {
            checkServer = new ServerSocket(TESTPORT);
            System.out.println("Aplikasi Server hidup ...");
        } catch (IOException e) {
            System.out.println(e);
        }

        try {
            clientSocket = checkServer.accept();
            is = new BufferedReader(new InputStreamReader(clientSocket.getInputStream()));
            os = new DataOutputStream(clientSocket.getOutputStream());
        } catch (Exception ei) {
            ei.printStackTrace();
        }

        try {
            line = is.readLine();
            System.out.println("Terima : " + line);
//            while (1==1) {
                if (line.compareTo("salam") == 0) {
                    os.writeBytes("salam juga");
                } else if (line.compareTo("bye") != 0){
                    os.writeBytes("Maaf, saya tidak mengerti ");
                }
                else {
                    os.writeBytes("bye");
//                    break;
                }
//            }
        } catch (IOException e) {
            System.out.println(e);
        }

        try {
            os.close();
            is.close();
            clientSocket.close();
        } catch (IOException ic) {
            ic.printStackTrace();
        }
    }
}
