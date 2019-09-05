// Learn more about F# at http://fsharp.org

open System
open System.Text.RegularExpressions
open FSharp.Data
open FSharpPlus

//
//type Color =
//    | White
//    | Red
//    | Blue
//    | Green
//    | Black
//    | Unspecified
//
//type ArtifactType =
//    | Clue
//    | Contraption
//    | Equipment
//    | Fortification
//    | Treasure
//    | Vehicle
//
//type CreatureType =
//    | Advisor
//    | Aetherborn
//    | Ally
//    | Angel
//    | Antelope
//    | Ape
//    | Archer
//    | Archon
//    | Army
//    | Artificer
//    | Assassin
//    | AssemblyWorker
//    | Atog
//    | Aurochs
//    | Avatar
//    | Azra
//    | Badger
//    | Barbarian
//    | Basilisk
//    | Bat
//    | Bear
//    | Beast
//    | Beeble
//    | Berserker
//    | Bird
//    | Blinkmoth
//    | Boar
//    | Bringer
//    | Brushwagg
//    | Camarid
//    | Camel
//    | Caribou
//    | Carrier
//    | Cat
//    | Centaur
//    | Cephalid
//    | Chimera
//    | Citizen
//    | Cleric
//    | Cockatrice
//    | Construct
//    | Coward
//    | Crab
//    | Crocodile
//    | Cyclops
//    | Dauthi
//    | Demon
//    | Deserter
//    | Devil
//    | Dinosaur
//    | Djinn
//    | Dragon
//    | Drake
//    | Dreadnought
//    | Drone
//    | Druid
//    | Dryad
//    | Dwarf
//    | Efreet
//    | Egg
//    | Elder
//    | Eldrazi
//    | Elemental
//    | Elephant
//    | Elf
//    | Elk
//    | Eye
//    | Faerie
//    | Ferret
//    | Fish
//    | Flagbearer
//    | Fox
//    | Frog
//    | Fungus
//    | Gargoyle
//    | Germ
//    | Giant
//    | Gnome
//    | Goat
//    | Goblin
//    | God
//    | Golem
//    | Gorgon
//    | Graveborn
//    | Gremlin
//    | Griffin
//    | Hag
//    | Harpy
//    | Hellion
//    | Hippo
//    | Hippogriff
//    | Homarid
//    | Homunculus
//    | Horror
//    | Horse
//    | Hound
//    | Human
//    | Hydra
//    | Hyena
//    | Illusion
//    | Imp
//    | Incarnation
//    | Insect
//    | Jackal
//    | Jellyfish
//    | Juggernaut
//    | Kavu
//    | Kirin
//    | Kithkin
//    | Knight
//    | Kobold
//    | Kor
//    | Kraken
//    | Lamia
//    | Lammasu
//    | Leech
//    | Leviathan
//    | Lhurgoyf
//    | Licid
//    | Lizard
//    | Manticore
//    | Masticore
//    | Mercenary
//    | Merfolk
//    | Metathran
//    | Minion
//    | Minotaur
//    | Mole
//    | Monger
//    | Mongoose
//    | Monk
//    | Monkey
//    | Moonfolk
//    | Mutant
//    | Myr
//    | Mystic
//    | Naga
//    | Nautilus
//    | Nephilim
//    | Nightmare
//    | Nightstalker
//    | Ninja
//    | Noggle
//    | Nomad
//    | Nymph
//    | Octopus
//    | Ogre
//    | Ooze
//    | Orb
//    | Orc
//    | Orgg
//    | Ouphe
//    | Ox
//    | Oyster
//    | Pangolin
//    | Pegasus
//    | Pentavite
//    | Pest
//    | Phelddagrif
//    | Phoenix
//    | Pilot
//    | Pincher
//    | Pirate
//    | Plant
//    | Praetor
//    | Prism
//    | Processor
//    | Rabbit
//    | Rat
//    | Rebel
//    | Reflection
//    | Rhino
//    | Rigger
//    | Rogue
//    | Sable
//    | Salamander
//    | Samurai
//    | Sand
//    | Saproling
//    | Satyr
//    | Scarecrow
//    | Scion
//    | Scorpion
//    | Scout
//    | Sculpture
//    | Serf
//    | Serpent
//    | Servo
//    | Shade
//    | Shaman
//    | Shapeshifter
//    | Sheep
//    | Siren
//    | Skeleton
//    | Slith
//    | Sliver
//    | Slug
//    | Snake
//    | Soldier
//    | Soltari
//    | Spawn
//    | Specter
//    | Spellshaper
//    | Sphinx
//    | Spider
//    | Spike
//    | Spirit
//    | Splinter
//    | Sponge
//    | Squid
//    | Squirrel
//    | Starfish
//    | Surrakar
//    | Survivor
//    | Tetravite
//    | Thalakos
//    | Thopter
//    | Thrull
//    | Treefolk
//    | Trilobite
//    | Triskelavite
//    | Troll
//    | Turtle
//    | Unicorn
//    | Vampire
//    | Vedalken
//    | Viashino
//    | Volver
//    | Wall
//    | Warrior
//    | Weird
//    | Werewolf
//    | Whale
//    | Wizard
//    | Wolf
//    | Wolverine
//    | Wombat
//    | Worm
//    | Wraith
//    | Wurm
//    | Yeti
//    | Zombie
//    | Zubera
//
//type EnchantmentType =
//    | Aura
//    | Cartouche
//    | Curse
//    | Saga
//    | Shrine
//
//type BasicLandType =
//    | Plains
//    | Island
//    | Swamp
//    | Mountain
//    | Forest
//
//type NonBasicLandType =
//    | Desert
//    | Gate
//    | Lair
//    | Locus
//    | Urzas
//    | Mine
//    | PowerPlant
//    | Tower
//
//type LandType =
//    | BasicLandType of BasicLandType
//    | NonBasicLandType of NonBasicLandType
//
//type PlaneswalkerType =
//    | Ajani
//    | Aminatou
//    | Angrath
//    | Arlinn
//    | Ashiok
//    | Bolas
//    | Chandra
//    | Dack
//    | Daretti
//    | Domri
//    | Dovin
//    | Elspeth
//    | Estrid
//    | Freyalise
//    | Garruk
//    | Gideon
//    | Huatli
//    | Jace
//    | Jaya
//    | Karn
//    | Kasmina
//    | Kaya
//    | Kiora
//    | Koth
//    | Liliana
//    | Nahiri
//    | Nissa
//    | Narset
//    | Nixilis
//    | Ral
//    | Rowan
//    | Saheeli
//    | Samut
//    | Sarkhan
//    | Serra
//    | Sorin
//    | Tamiyo
//    | Teferi
//    | Teyo
//    | Tezzeret
//    | Tibalt
//    | Ugin
//    | Venser
//    | Vivien
//    | Vraska
//    | Will
//    | Windgrace
//    | Xenagos
//    | Yanggu
//    | Yanling
//
//type Creature = {
//    abilities : string list
//    power : int option
//    toughness : int option
//    counter : int
//}
//
type CardType =
    | Land of string
    | Creature //of CreatureType * Creature
    | Planeswalker //of PlaneswalkerType * int * (int * string) list
    | Enchantment //of EnchantmentType
    | Artifact //of ArtifactType * (string list)
    | Instant //of string list
    | Sorcery //of string list
//
//type Rarity =
//    | Common
//    | Uncommon
//    | Rare
//    | MythicRare
//
type Card = {
    color : string
    cardType : CardType
    text : string
//    rarity : Rarity
}

let wrapText (text : string) margin =
    let mutable start = 0
    let mutable end_ = 0
    let text = Regex.Replace(text, @"\s", " ").Trim()
    end_ <- start + margin
    seq {
        while (end_  < text.Length) do
            while (text.[end_] <> ' ' && end_ > start) do
                end_ <- end_ - 1

            if (end_ = start) then
                end_ <- start + margin;

            yield text.Substring(start, end_ - start)

            start <- end_ + 1
            end_ <- start + margin

        if (start < text.Length) then
            yield text.Substring(start)
    }

let mvprintmaxw x y (s : string) (maxw : int) =
    let lines = wrapText s maxw |> List.ofSeq
    lines
    |> List.iteri (fun i line ->
        Console.CursorLeft <- x
        Console.CursorTop <- y + i
        Console.WriteLine (sprintf "%s" line)
        )

//let printCard x y name (card : Card) =
//    let w = 35
//    Console.BackgroundColor <- ConsoleColor.DarkRed
//    mvprintmaxw x y (sprintf "%s" name) w
//    Console.ResetColor ()
//
//    let printCost () =
//        card.manaCost
//        |> List.iteri (fun i (n, c) ->
//            Console.Write (sprintf "%d %A" n c)
//            if i < card.manaCost.Length - 1 then Console.Write ", "
//            )
//    match card.cardType with
//        | Planeswalker (type_, loyalty, abilities) ->
//            Console.ForegroundColor <- ConsoleColor.Yellow
//            Console.WriteLine (sprintf "Legendary Planeswalker - %A" type_)
//            Console.ResetColor ()
//            Console.WriteLine ()
//            printCost ()
//            Console.WriteLine ()
//            Console.WriteLine (sprintf "%d Loyalty" loyalty)
//            Console.ForegroundColor <- ConsoleColor.Gray
//            abilities |> List.iter (fun (cost, desc) ->
//                mvprintmaxw x (Console.CursorTop + 1) (sprintf "%d: %s" cost desc) w
//                )
//            Console.ResetColor ()
//        | _ -> ()

let JSStr (x : JsonValue) = x.AsString()

module JsonValue =
    let asArray (x : JsonValue) = x.AsArray()
    let asString (x : JsonValue) = x.AsString()

#r @"C:\Users\se-krilofb-01\.nuget\packages\fsharpplus\1.0.0\lib\netstandard2.0\FSharpPlus.dll"
#r @"C:\Users\se-krilofb-01\.nuget\packages\fsharp.data\3.1.1\lib\netstandard2.0\FSharp.Data.dll"
open FSharp.Data
let cards = JsonValue.Load (@"C:\Projects\magic\AllCards.json")

let x =
    monad {
        let! card = cards.TryGetProperty("Forest")
        let! types = card.TryGetProperty("types") |>> JsonValue.asArray |>> map JsonValue.asString
        return
            match types with
                | ["Land"] ->
                    {
                        color = card.GetProperty("type") |> JsonValue.asString
                        cardType = card.GetProperty("type") |> JsonValue.asString |> Land
                        text = card.GetProperty("text") |> JsonValue.asString
                    }
    //            | _ -> ()


//        let! cardType = card.TryGetProperty("type") |>> JSStr
//
//        let! subtypes = card.TryGetProperty("subtypes")
////        let! manaCost = card.TryGetProperty("manaCost")
////        let! colorIdentity = card.TryGetProperty("colorIdentity")
//////        let! zz = card.TryGetProperty("loyalty")
////        let! manaCost = card.TryGetProperty("manaCost")
////        let! text = card.TryGetProperty("text")
////        let! power = card.TryGetProperty("power")
////        let! toughness = card.TryGetProperty("toughness")
////        let! zz = card.TryGetProperty("rarity")
//        return
//            {|
//                cardType = cardType
//                subtypes = subtypes.AsArray()
////                manaCost = manaCost.AsString()
////                colorIdentity = colorIdentity.AsString()
////                text = text.AsString()
////                power = power.AsString()
////                toughness = toughness.AsString()
//            |}
    }

System.IO.File.WriteAllText(@"C:\Users\se-krilofb-01\Documents\magic.json", x.Value)

[<EntryPoint>]
let main argv =



    0
