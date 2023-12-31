﻿using ModLoader.API;
using Network.Packets;
using Z64Online.OoTOnline;
using Buffer = NodeBuffer.Buffer;

namespace Z64Online;

public class Z64O_ScenePacket
{
    public u16 scene { get; set; }
    public int age { get; set; }
    public NetworkPlayer player { get; set; }
    public string lobby { get; set; }

    public Z64O_ScenePacket(u16 scene, int age, string lobby, NetworkPlayer player)
    {
        this.scene = scene;
        this.age = age;
        this.player = player;
        this.lobby = lobby;
    }
}

public class Z64O_ClientSceneContextUpdate
{
    public u32 chests { get; set; }
    public u32 switches { get; set; }
    public u32 collect { get; set; }
    public u32 clear { get; set; }
    public u32 temp { get; set; }
    public u16 scene { get; set; }
    public int world { get; set; }
    public string lobby { get; set; }
    public NetworkPlayer player { get; set; }

    public Z64O_ClientSceneContextUpdate(u32 chests, u32 switches, u32 collect, u32 clear, u32 temp, u16 scene, int world, string lobby, NetworkPlayer player)
    {
        this.chests = chests;
        this.switches = switches;
        this.collect = collect;
        this.clear = clear;
        this.temp = temp;
        this.scene = scene;
        this.world = world;
        this.lobby = lobby;
        this.player = player;
    }
}

public class Z64O_ErrorPacket
{
    public string message;
    public string lobby;

    public Z64O_ErrorPacket(string message, string lobby)
    {
        this.message = message;
        this.lobby = lobby;
    }
}

public class Z64O_DownloadResponsePacket
{
    public OoTOSyncSave save { get; set; }
    public IKeyRing keys { get; set; }
    public string lobby { get; set; }
    public NetworkPlayer player { get; set; }

    public Z64O_DownloadResponsePacket(string lobby, NetworkPlayer player)
    {
        this.lobby = lobby;
        this.player = player;
    }
}

public class Z64O_DownloadRequestPacket
{
    public OoTOSyncSave save { get; set; }
    public string lobby { get; set; }
    public NetworkPlayer player { get; set; }

    public Z64O_DownloadRequestPacket(OoTOSyncSave save, string lobby, NetworkPlayer player)
    {
        this.save = save;
        this.lobby = lobby;
        this.player = player;
    }
}

public class Z64O_UpdateSaveDataPacket
{
    public OoTOSyncSave save { get; set; }
    public int world { get; set; }
    public NetworkPlayer player { get; set; }
    public string lobby { get; set; }

    public Z64O_UpdateSaveDataPacket(OoTOSyncSave save, int world, NetworkPlayer player, string lobby)
    {
        this.save = save;
        this.world = world;
        this.player = player;
        this.lobby = lobby;
    }
}

public class Z64O_RupeePacket
{
    public u16 rupees { get; set; }
    public string lobby { get; set; }
    public NetworkPlayer player { get; set; }

    public Z64O_RupeePacket(u16 rupees, string lobby, NetworkPlayer player)
    {
        this.rupees = rupees;
        this.lobby = lobby;
        this.player = player;
    }
}
