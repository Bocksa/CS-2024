﻿import math

def Simulate(ImpactForce, Velocity, AngleOfImpact):
    Force = ImpactForce - 0.3
    collisionChance = ((120 * Force) / Velocity) * math.fabs(math.cos((AngleOfImpact - 90) * math.pi / 720))

    if (collisionChance > 1):
        collisionChance = 1
    elif (collisionChance < 0):
        collisionChance = 0
    return collisionChance
    
