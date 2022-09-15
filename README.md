# Unity-Seed-Control
Project start on 15-Sep-2022


Scripts for multi-seed usage. Allow getting random numbers in different seeds easily.


[![License: GPL v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
![GitHub top language](https://img.shields.io/github/languages/top/soranoo/Unity-Seed-Control)
&nbsp;[![Donation](https://img.shields.io/static/v1?label=Donation&message=❤️&style=social)](https://github.com/soranoo/Donation)

## :old_key: Features
* Use custom seed without affecting the global seed.

## :space_invader: Usage
Use custom seed:
```csharp
// define a seed
Seed seed = new Seed("my_seed");

// get a random number in your custom seed
seed.RandomNumber(0, 100);

```
Use global seed:
```csharp
// get a random number in the global seed
UnityEngine.Random.Range(0, 100)

```


## :star: TODO
* Waiting for your suggestion.

## :bug: Known Issues
* Waiting for your report.

## :coffee: Donation
Love the scripts? Consider a donation to support our work.

[!["Donation"](https://raw.githubusercontent.com/soranoo/Donation/main/resources/image/DonateBtn.png)](https://github.com/soranoo/Donation) <- click me~