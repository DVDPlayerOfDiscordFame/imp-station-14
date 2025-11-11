using Content.Shared.Damage;
using Robust.Shared.GameStates;

namespace Content.Shared.Weapons.Ranged.Components;

/// <summary>
/// This component modifies the damage of the projectiles the gun it is attached to shoots.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class GunDamageModifierComponent : Component
{
    /// <summary>
    /// Additional damage added onto the projectile's base damage.
    /// </summary>
    [DataField]
    public DamageSpecifier Damage = new();
}
