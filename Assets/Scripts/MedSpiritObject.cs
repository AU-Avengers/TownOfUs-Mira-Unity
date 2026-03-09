using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InnerNet;

namespace TownOfUs.Modules.MedSpirit
{
    public class MedSpiritObject : InnerNetObject
    {
        public PlayerControl? Owner;
        public Rigidbody2D Rigidbody;
        public MedSpiritNetTransform NetTransform;
        public SpriteRenderer Rend;
    }

}