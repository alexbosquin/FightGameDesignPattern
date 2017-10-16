# Fight Game Design Pattern
This project was created by me to test my abilities over design patterns

## Used Design Patterns

*Builder
*Singleton
*Observer
*State
*Template

### UML Prototype
![UML](https://i.imgur.com/bmezYsn.png)

```
Why these Patterns?
```

### Builder

Builder is commonly used to instantiate complex objects, in fight games the characters has a lot of properties: name,stateTree,state,
simple attacks like punch or kick, combos which are a set of simple attacks,pallete, etc.
In this project you can create a instance of a character: Ryu or Chun-li, with their own properties

```
class CharacterChunLi : CharacterBuilder
    {
        private Character character;
        public void build()
        {
            character = new Character();
            character.setName("Chun-Li").setState(new Normal()).build();
        }

        public Character getCharacter()
        {
            return character;
        }
    }
```

## Singleton

For any game you probably will create in your life, you need to persist data between scenes(unity)/stages(game maker). The most common
solution is this pattern. So When a player select , for example, ryu on character select screen it sends to the ManagerGame(Singleton)
the instance of that character.

```
Character ryu = ManagerGame.getInstance().instantiateCharacter();
```

## Observer

Fight games has lifebars, so they need to be notified when the character gets hurted.

```
public class ObserverLifebar : Observer
    {
        public void notify()
        {
            hit(10);
            Console.WriteLine("Losing Life");
        }
     ....
```

## State

Decent games uses Finite State Machine to facilitate the character controller,animations sets, and so more. The state pattern do this for use

```
class Normal : STATE
    {
        public  override void jump()
        {
            Console.WriteLine("Normal Jumping");
        }

         public override void walk()
        {
            Console.WriteLine("Normal Walking");
        }
    }
```

## Template

As I wrote above, combos are a set of simple attacks, for example: punch,kick,special,punch. The template pattern execute this set of attacks:

```
class ComboA : Combo
    {
        protected override void execute()
        {
                attacks.Add(new Punch());
                attacks.Add(new Kick());

            foreach(Attack a in attacks)
            {
                a.execute();
            }

        }
    }
```


## Built With

* [Visual Studio 2017](https://www.visualstudio.com) - The software used
* [Draw IO](https://www.draw.io) - The UML builder

## Contributing

Use it as you wish :D


## Author

* **Alexandre Bosco** - *All work* - [alexbosquin](https://github.com/alexbosquin)

## Acknowledgments

* Filipe Guelber, my design pattern teacher, who gives his utmost to pass his knowledge.
