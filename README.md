# EventStack
Add events and value mods to Unity3D with ease. Especially useful for RPGs! An Event Stack is essentially a list of delegates which run one after the other, each modifying the input value and finally returning the final value. In my game, I use them for my perk system, to allow my perks to modify a huge number of different values for my characters.

Simple Example:
```
//On Character
public EventStack<float> ModifyWalkSpeed;

public float GetWalkSpeed() 
{
  float speed = speed * agility + 3;
  return ModifyWalkSpeed.RunStack(speed);
}

...

public void RegisterSpeedBoostPerk() 
{
  character.ModifyWalkSpeed.RegisterMod((speed) => { return speed * 2; });
}
```
