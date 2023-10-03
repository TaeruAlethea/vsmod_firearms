﻿using Vintagestory.API.Common;
using Vintagestory.API.MathTools;

namespace MaltiezFirearms.FiniteStateMachine.Systems
{
    public interface IVariantsAnimation
    {
        int StartAnimation(int firstVariant, int lastVariant, ItemSlot slot, EntityAgent player);
        void CancelAnimation(int animationId);
        void SetVariant(int variant, ItemSlot slot, EntityAgent player);
    }
    
    public interface IAmmoSelector
    {
        ItemStack GetSelectedAmmo(ItemSlot slot);
        ItemStack TakeSelectedAmmo(ItemSlot slot);
    }

    public interface IAimingSystem
    {
        Vec3f GetSpawnLocationOffset();
        Vec3f GetShootingDirectionOffset();
    }
}