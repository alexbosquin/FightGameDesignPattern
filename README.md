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


## Built With

* [Visual Studio 2017](https://www.visualstudio.com) - The software used
* [Draw IO](https://www.draw.io) - The UML builder

## Contributing

Use it as you wish :D


## Author

* **Alexandre Bosco** - *All work* - [alexbosquin](https://github.com/alexbosquin)

## Acknowledgments

* Filipe Guelber, my design pattern teacher, who gives his utmost to pass his knowledge.
