using Content.Shared.Examine;
using Content.Shared.Weapons.Ranged.Components;
using Content.Shared.Weapons.Ranged.Events;
using Content.Shared.Projectiles;

namespace Content.Shared.Weapons.Ranged.Systems;


public sealed class GunDamageModifierSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<GunDamageModifierComponent, GunShotEvent>(OnGunShotDamage);
        //SubscribeLocalEvent<GunDamageModifierComponent, ExaminedEvent>(OnExamine);
    }

    private void OnGunShotDamage(Entity<GunDamageModifierComponent> ent, ref GunShotEvent args)
    {
        foreach (var (ammo, _) in args.Ammo)
        {
            if (TryComp<ProjectileComponent>(ammo, out var proj))
                proj.Damage += ent.Comp.Damage;
        }
    }
}
