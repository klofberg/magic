// Learn more about F# at http://fsharp.org

open System
open System.Text.RegularExpressions
open FSharp.Data

type Color =
    | White
    | Red
    | Blue
    | Green
    | Black
    | Unspecified

type ArtifactType =
    | Clue
    | Contraption
    | Equipment
    | Fortification
    | Treasure
    | Vehicle

type CreatureType =
    | Advisor
    | Aetherborn
    | Ally
    | Angel
    | Antelope
    | Ape
    | Archer
    | Archon
    | Army
    | Artificer
    | Assassin
    | AssemblyWorker
    | Atog
    | Aurochs
    | Avatar
    | Azra
    | Badger
    | Barbarian
    | Basilisk
    | Bat
    | Bear
    | Beast
    | Beeble
    | Berserker
    | Bird
    | Blinkmoth
    | Boar
    | Bringer
    | Brushwagg
    | Camarid
    | Camel
    | Caribou
    | Carrier
    | Cat
    | Centaur
    | Cephalid
    | Chimera
    | Citizen
    | Cleric
    | Cockatrice
    | Construct
    | Coward
    | Crab
    | Crocodile
    | Cyclops
    | Dauthi
    | Demon
    | Deserter
    | Devil
    | Dinosaur
    | Djinn
    | Dragon
    | Drake
    | Dreadnought
    | Drone
    | Druid
    | Dryad
    | Dwarf
    | Efreet
    | Egg
    | Elder
    | Eldrazi
    | Elemental
    | Elephant
    | Elf
    | Elk
    | Eye
    | Faerie
    | Ferret
    | Fish
    | Flagbearer
    | Fox
    | Frog
    | Fungus
    | Gargoyle
    | Germ
    | Giant
    | Gnome
    | Goat
    | Goblin
    | God
    | Golem
    | Gorgon
    | Graveborn
    | Gremlin
    | Griffin
    | Hag
    | Harpy
    | Hellion
    | Hippo
    | Hippogriff
    | Homarid
    | Homunculus
    | Horror
    | Horse
    | Hound
    | Human
    | Hydra
    | Hyena
    | Illusion
    | Imp
    | Incarnation
    | Insect
    | Jackal
    | Jellyfish
    | Juggernaut
    | Kavu
    | Kirin
    | Kithkin
    | Knight
    | Kobold
    | Kor
    | Kraken
    | Lamia
    | Lammasu
    | Leech
    | Leviathan
    | Lhurgoyf
    | Licid
    | Lizard
    | Manticore
    | Masticore
    | Mercenary
    | Merfolk
    | Metathran
    | Minion
    | Minotaur
    | Mole
    | Monger
    | Mongoose
    | Monk
    | Monkey
    | Moonfolk
    | Mutant
    | Myr
    | Mystic
    | Naga
    | Nautilus
    | Nephilim
    | Nightmare
    | Nightstalker
    | Ninja
    | Noggle
    | Nomad
    | Nymph
    | Octopus
    | Ogre
    | Ooze
    | Orb
    | Orc
    | Orgg
    | Ouphe
    | Ox
    | Oyster
    | Pangolin
    | Pegasus
    | Pentavite
    | Pest
    | Phelddagrif
    | Phoenix
    | Pilot
    | Pincher
    | Pirate
    | Plant
    | Praetor
    | Prism
    | Processor
    | Rabbit
    | Rat
    | Rebel
    | Reflection
    | Rhino
    | Rigger
    | Rogue
    | Sable
    | Salamander
    | Samurai
    | Sand
    | Saproling
    | Satyr
    | Scarecrow
    | Scion
    | Scorpion
    | Scout
    | Sculpture
    | Serf
    | Serpent
    | Servo
    | Shade
    | Shaman
    | Shapeshifter
    | Sheep
    | Siren
    | Skeleton
    | Slith
    | Sliver
    | Slug
    | Snake
    | Soldier
    | Soltari
    | Spawn
    | Specter
    | Spellshaper
    | Sphinx
    | Spider
    | Spike
    | Spirit
    | Splinter
    | Sponge
    | Squid
    | Squirrel
    | Starfish
    | Surrakar
    | Survivor
    | Tetravite
    | Thalakos
    | Thopter
    | Thrull
    | Treefolk
    | Trilobite
    | Triskelavite
    | Troll
    | Turtle
    | Unicorn
    | Vampire
    | Vedalken
    | Viashino
    | Volver
    | Wall
    | Warrior
    | Weird
    | Werewolf
    | Whale
    | Wizard
    | Wolf
    | Wolverine
    | Wombat
    | Worm
    | Wraith
    | Wurm
    | Yeti
    | Zombie
    | Zubera

type EnchantmentType =
    | Aura
    | Cartouche
    | Curse
    | Saga
    | Shrine

type BasicLandType =
    | Plains
    | Island
    | Swamp
    | Mountain
    | Forest

type NonBasicLandType =
    | Desert
    | Gate
    | Lair
    | Locus
    | Urzas
    | Mine
    | PowerPlant
    | Tower

type LandType =
    | BasicLandType
    | NonBasicLandType

type PlaneswalkerType =
    | Ajani
    | Aminatou
    | Angrath
    | Arlinn
    | Ashiok
    | Bolas
    | Chandra
    | Dack
    | Daretti
    | Domri
    | Dovin
    | Elspeth
    | Estrid
    | Freyalise
    | Garruk
    | Gideon
    | Huatli
    | Jace
    | Jaya
    | Karn
    | Kasmina
    | Kaya
    | Kiora
    | Koth
    | Liliana
    | Nahiri
    | Nissa
    | Narset
    | Nixilis
    | Ral
    | Rowan
    | Saheeli
    | Samut
    | Sarkhan
    | Serra
    | Sorin
    | Tamiyo
    | Teferi
    | Teyo
    | Tezzeret
    | Tibalt
    | Ugin
    | Venser
    | Vivien
    | Vraska
    | Will
    | Windgrace
    | Xenagos
    | Yanggu
    | Yanling

type Creature = {
    abilities : string list
    power : int option
    toughness : int option
    counter : int
}

type CardType =
    | Land of LandType
    | Creature of CreatureType * Creature
    | Planeswalker of PlaneswalkerType * int * (int * string) list
    | Enchantment of EnchantmentType
    | Artifact of ArtifactType * (string list)
    | Instant of string list
    | Sorcery of string list

type Rarity =
    | Common
    | Uncommon
    | Rare
    | MythicRare

type Card = {
    color : Color
    manaCost : (int * Color) list
    cardType : CardType
    rarity : Rarity
}

type Gatherer = HtmlProvider<"https://gatherer.wizards.com/Pages/Search/Default.aspx?name=+[Ajani]+[Goldmane]">


let loadCard name =
    let x = Gatherer.Load ("https://gatherer.wizards.com/Pages/Search/Default.aspx?name=+[Ajani]+[Goldmane]")
    let s =
        x.Tables.Table2.Rows
        |> Seq.head
        |> fun row -> row.Column2

    ()

let core2020 =
    [
        "Aerial Assult", {
            color = White
            manaCost = [
                2, Unspecified
                1, White
            ]
            cardType = Sorcery ["Destroy target tapped creature. You gain 1 life for each creature you control with flying."]
            rarity = Common
        }
        "Ajani, Strength of the Pride", {
            color = White
            manaCost = [
                2, Unspecified
                2, White
            ]
            cardType = Planeswalker
                (Ajani,
                5,
                [
                    1, "You gain life equal to the number of creatures you control plus the number of planeswalkers you control."
                    -2, "Create a 2/2 white Cat Soldier creature token named Ajani's Pridemate with \"Whenever you gain life, put a +1/+1 counter on Ajani's Pridemate.\""
                    0, "If you have at least 15 life more than your starting life total, exile Ajani, Strength of pride and each artifact and creature your opponents control."
                ])
            rarity = MythicRare
        }
        "Ancestral Blade", {
            color = White
            manaCost = [
                1, Unspecified
                1, White
            ]
            cardType = Artifact
                (Equipment,
                [
                    "When Ancestral Blade enters the battlefield, create a 1/1 white Soldier create token, then attach Ancestral Blade to it."
                    "Equipped creature gets +1/+1"
                    "Equip 1 unspecified mana (1 unspecified mana: Attach to target creature you control. Equip only as a sorcery.)"
                ])
            rarity = Rare
        }
    ]
    |> Map.ofList

open System.Text
open System.Text.RegularExpressions

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

//        mvprintw (y + int16 i, x, line) |> ignore
        )
    //List.length lines

let printCard x y name (card : Card) =
    let w = 35
    Console.BackgroundColor <- ConsoleColor.DarkRed
    mvprintmaxw x y (sprintf "%s" name) w
    Console.ResetColor ()

    let printCost () =
        card.manaCost
        |> List.iteri (fun i (n, c) ->
            Console.Write (sprintf "%d %A" n c)
            if i < card.manaCost.Length - 1 then Console.Write ", "
            )
    match card.cardType with
        | Planeswalker (type_, loyalty, abilities) ->
            Console.ForegroundColor <- ConsoleColor.Yellow
            Console.WriteLine (sprintf "Legendary Planeswalker - %A" type_)
            Console.ResetColor ()
            Console.WriteLine ()
            printCost ()
            Console.WriteLine ()
            Console.WriteLine (sprintf "%d Loyalty" loyalty)
            Console.ForegroundColor <- ConsoleColor.Gray
            abilities |> List.iter (fun (cost, desc) ->
                mvprintmaxw x (Console.CursorTop + 1) (sprintf "%d: %s" cost desc) w
                )
            Console.ResetColor ()
        | _ -> ()


[<EntryPoint>]
let main argv =

    Console.WriteLine ( loadCard "" )
//    Console.Clear ()
//    Console.ResetColor ()
//
//    let (name, card) = Map.toList core2020 |> List.head
//    printCard 0 0 name card
//
//    let (name, card) = Map.toList core2020 |> List.skip 1 |> List.head
//    printCard 36 0 name card

    0
