using System;
using System.Collections.Generic;
using System.Drawing;

//SERVER
[Serializable]
public class ClientPacket
{
    private string userName;
    private Image contactPicture;
    private string receiverUserName;
    private string message;
    private string clientIP;
    private string receiverClientIP;
    private int type;
    private List<ClientPacket> friendsList;
    bool canHandlePackets = true;

    /*public enum packetTypes
    {
        Connect,
        Disconnect,
        FriendRequest,
        Message,
    }*/

    public ClientPacket(TCP_Server.ClientPackage package, int type)//Connect Packet
    {
        this.userName = package.getUserName();
        this.contactPicture = package.getContactPicture();
        this.clientIP = package.getClientIP();
        this.type = type;
    }

    public ClientPacket(string userName, string clientIP, string message, string receiverUserName, string receiverClientIP)
    {
        this.userName = userName;
        this.receiverUserName = receiverUserName;
        this.clientIP = clientIP;
        this.receiverClientIP = receiverClientIP;
        this.message = message;//MSG
        type = 3;
    }

    public ClientPacket(List<ClientPacket> friendsList)
    {
        this.friendsList = friendsList;
        type = 2;
    }

    public void setPacketSupport(bool canHandlePackets) { this.canHandlePackets = canHandlePackets; }
    public bool packetSupport() { return canHandlePackets; }
    public string getUsername() { return userName; }
    public Image getContactPicture() { return contactPicture; }
    public string getClientIP() { return clientIP; }
    public string getReceiverUserName() { return receiverUserName; }
    public string getReceiverIP() { return receiverClientIP; }
    public string getMessage() { return message; }
    public int getPacketType() { return type; }
}