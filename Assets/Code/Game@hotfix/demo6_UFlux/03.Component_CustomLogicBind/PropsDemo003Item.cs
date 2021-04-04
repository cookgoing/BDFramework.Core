﻿﻿using BDFramework.UFlux;
using BDFramework.UFlux.View.Props;
using UnityEngine.UI;

namespace Game.demo6_UFlux._05.NodeHelper
{
    public class PropsDemo003Item : PropsBase
    {
        [TransformPath("Img_Star")]
        [ComponentValueBind(nameof(Image),nameof(Image.overrideSprite))]
        public string EquipmentIconPath;
        
        
        [TransformPath("txt_EquipmentName")]
        [ComponentValueBind(nameof(Text),nameof(Text.text))]
        public string EquipmentName;
        
    }
}