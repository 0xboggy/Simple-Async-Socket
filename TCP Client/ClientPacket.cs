using System;
using System.Collections.Generic;
using System.Drawing;

//CLIENT
[Serializable]
public class ClientPacket
{
    private string userName;
    private string receiverUserName;
    private string message;
    private string clientIP;
    private string receiverClientIP;
    private int type;
    private List<ClientPacket> friendsList;
    private Image contactPicture;
    bool canHandlePackets = true;

    /*public enum packetTypes
    {
        Connect,
        Disconnect,
        FriendRequest,
        Message,
    }*/

    public ClientPacket(string userName, Image contactPicture, int type,string clientIP = "")
    {
        this.userName = userName;
        this.contactPicture = contactPicture;
        this.type = type;
        this.clientIP = clientIP;
    }

    //Message Packet
    public ClientPacket(string userName, string clientIP, string message, string receiverUserName, string receiverClientIP)
    {
        this.userName = userName;
        this.clientIP = clientIP;
        this.message = message;//MSG
        this.receiverUserName = receiverUserName;
        this.receiverClientIP = receiverClientIP;//TO
        type = 3;
    }

    public string getUsername() { return userName; }
    public Image getContactPicture() { return contactPicture; }
    public string getClientIP() { return clientIP; }
    public string getReceiverUserName() { return receiverUserName; }
    public string getReceiverIP() { return receiverClientIP; }
    public string getMessage() { return message; }
    public int getPacketType() { return type; }
    public List<ClientPacket> getFriendsList() { return friendsList; }
}