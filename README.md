# \# 🦸‍♂️ Superhero Combat Arena

# \*A fast-paced 3D fighting game built in Unity, inspired by Marvel’s legendary heroes.\*

# 

# !\[Gameplay Preview](docs/screenshot.png)

# 

# ---

# 

# \## 🎮 Overview

# 

# \*\*Superhero Combat Arena\*\* is a third-person action fighting game that blends cinematic animations, responsive controls, and physics-based combat.  

# Play as a powerful hero capable of \*\*punches, kicks, combos, and ultimate abilities\*\*, all driven by Unity’s animation and input systems.

# 

# > ⚔️ The goal: Defeat waves of enemies using your reflexes, combo chains, and power attacks.

# 

# ---

# 

# \## 🧠 Core Features

# 

# \- 🥊 \*\*Trigger-based combat system\*\* — animations for punches, kicks, and combos tied to button inputs.  

# \- 🎥 \*\*Cinematic camera\*\* that follows action dynamically.  

# \- 💥 \*\*Physics-driven hit reactions\*\* with explosion or impact VFX.  

# \- 🔄 \*\*Smooth animation transitions\*\* using Unity’s Animator Controller.  

# \- 🎨 \*\*Custom hero models \& environments\*\* for immersive battles.  

# \- 🧩 \*\*Modular design\*\* — easy to expand with new characters, abilities, and arenas.

# 

# ---

# 

# \## 🕹️ Controls

# 

# | Action | Keyboard / Controller | Animation Trigger |

# |:--|:--|:--|

# | Move | `WASD` / Left Stick | Movement Blend Tree |

# | Light Punch | `J` / Right Trigger (RT) | `Trigger("Punch")` |

# | Heavy Kick | `K` / Left Trigger (LT) | `Trigger("Kick")` |

# | Jump | `Space` / A Button | `Trigger("Jump")` |

# | Block | `L` / Right Bumper (RB) | `Trigger("Block")` |

# | Special Power | `H` / Y Button | `Trigger("Power")` |

# 

# Each combat animation is triggered via Unity’s \*\*Animator Parameters\*\* using:

# ```csharp

# animator.SetTrigger("Kick");

# animator.SetTrigger("Punch");



