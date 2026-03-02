package phanmem;

import javax.swing.*;
import javax.swing.border.EmptyBorder;
import java.awt.*;
import java.io.*;
import java.net.*;

public class Client extends JFrame {

    private JTextArea chatArea;
    private JTextField messageField;
    private JButton sendButton;

    private Socket socket;
    private BufferedReader in;
    private PrintWriter out;

    public Client() {

        setTitle("💬 Client Chat");
        setSize(500, 500);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        getContentPane().setBackground(new Color(30,30,30));
        setLayout(new BorderLayout(10,10));

        chatArea = new JTextArea();
        chatArea.setEditable(false);
        chatArea.setFont(new Font("Segoe UI", Font.PLAIN, 14));
        chatArea.setBackground(new Color(45,45,45));
        chatArea.setForeground(Color.WHITE);
        chatArea.setLineWrap(true);
        chatArea.setWrapStyleWord(true);
        chatArea.setBorder(new EmptyBorder(10,10,10,10));

        JScrollPane scroll = new JScrollPane(chatArea);
        scroll.setBorder(null);
        add(scroll, BorderLayout.CENTER);

        JPanel panel = new JPanel(new BorderLayout(10,10));
        panel.setBackground(new Color(30,30,30));
        panel.setBorder(new EmptyBorder(10,10,10,10));

        messageField = new JTextField();
        messageField.setFont(new Font("Segoe UI", Font.PLAIN, 14));
        messageField.setBackground(new Color(60,60,60));
        messageField.setForeground(Color.WHITE);
        messageField.setCaretColor(Color.WHITE);

        sendButton = new JButton("Send");
        sendButton.setBackground(new Color(0,120,215));
        sendButton.setForeground(Color.WHITE);
        sendButton.setFocusPainted(false);

        panel.add(messageField, BorderLayout.CENTER);
        panel.add(sendButton, BorderLayout.EAST);
        add(panel, BorderLayout.SOUTH);

        sendButton.addActionListener(e -> sendMessage());
        messageField.addActionListener(e -> sendMessage());

        setVisible(true);
        connectToServer();
    }

    private void connectToServer() {
        try {
            socket = new Socket("localhost", 5000);
            appendMessage("🟢 Đã kết nối server!\n\n", Color.GREEN);

            in = new BufferedReader(new InputStreamReader(socket.getInputStream()));
            out = new PrintWriter(socket.getOutputStream(), true);

            new Thread(() -> {
                try {
                    String message;
                    while ((message = in.readLine()) != null) {
                        appendMessage("🖥 Server: " + message + "\n", new Color(255,200,0));
                    }
                } catch (IOException e) {
                    appendMessage("❌ Mất kết nối!\n", Color.RED);
                }
            }).start();

        } catch (IOException e) {
            appendMessage("Không kết nối được server!\n", Color.RED);
        }
    }

    private void sendMessage() {
        String message = messageField.getText();
        if (!message.equals("")) {
            out.println(message);
            appendMessage("🧑 Me: " + message + "\n", new Color(0,200,255));
            messageField.setText("");
        }
    }

    private void appendMessage(String msg, Color color) {
        chatArea.setForeground(color);
        chatArea.append(msg);
        chatArea.setForeground(Color.WHITE);
    }

    public static void main(String[] args) {
        new Client();
    }
}