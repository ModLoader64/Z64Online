﻿
using OoT.API;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Z64Online
{
    public class OoTOnlineStorage : OoTOnlineStorageBase
    {
        public string lobby;
        public NetworkPlayer[] networkPlayerInstances = { };
        public PlayerSceneServer[] players;
        public OotOnlineSave_Server[] worlds = { };

        public OoTOnlineStorage(string lobby)
        {
            this.lobby = lobby;
        }
    }

    public class PlayerSceneServer
    {
        public string uuid;
        public int scene;

        public PlayerSceneServer(string uuid, int scene)
        {
            this.uuid = uuid;
            this.scene = scene;
        }
    }
    public class OoTOSyncSave
    {
        public bool isOoTR;
        public bool isVanilla;
        public OoTOnlineInventorySync? inventory = new OoTOnlineInventorySync();
    }

    public class OoTOnlineInventorySync
    {
        public InventoryItem dekuSticks = InventoryItem.NONE;
        public InventoryItem dekuNuts = InventoryItem.NONE;
        public InventoryItem bombs = InventoryItem.NONE;
        public InventoryItem bow = InventoryItem.NONE;
        public InventoryItem fireArrows = InventoryItem.NONE;
        public InventoryItem dinsFire = InventoryItem.NONE;
        public InventoryItem slingshot = InventoryItem.NONE;
        public InventoryItem ocarina = InventoryItem.NONE;
        public InventoryItem bombchus = InventoryItem.NONE;
        public InventoryItem hookshot = InventoryItem.NONE;
        public InventoryItem iceArrows = InventoryItem.NONE;
        public InventoryItem faroresWind = InventoryItem.NONE;
        public InventoryItem boomerang = InventoryItem.NONE;
        public InventoryItem lensOfTruth = InventoryItem.NONE;
        public InventoryItem magicBeans = InventoryItem.NONE;
        public InventoryItem megatonHammer = InventoryItem.NONE;
        public InventoryItem lightArrows = InventoryItem.NONE;
        public InventoryItem nayrusLove = InventoryItem.NONE;
        public InventoryItem bottle1 = InventoryItem.NONE;
        public InventoryItem bottle2 = InventoryItem.NONE;
        public InventoryItem bottle3 = InventoryItem.NONE;
        public InventoryItem bottle4 = InventoryItem.NONE;
        public InventoryItem childTrade = InventoryItem.NONE;
        public InventoryItem adultTrade = InventoryItem.NONE;

        public bool kokiriSword = false;
        public bool masterSword = false;
        public bool giantsKnife = false;
        public bool biggoronSword = false;
        public bool dekuShield = false;
        public bool hylianShield = false;
        public bool mirrorShield = false;
        public bool kokiriTunic = false;
        public bool goronTunic = false;
        public bool zoraTunic = false;
        public bool kokiriBoots = false;
        public bool ironBoots = false;
        public bool hoverBoots = false;

    }

    class OoTOnlineQuestStatus
    {

    }

    public class OOTKeyRingServer : IKeyRing
    {
        public byte[] keys { get; set; }
    }

    public class OotOnlineSave_Server
    {
        public bool saveGameSetup = false;
        public OoTOSyncSave save = new OoTOSyncSave();
        public IKeyRing keys = new OOTKeyRingServer();
    }
}