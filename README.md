# Ian-s-VR-Room

## Features

### Room Design
- Designed room environment for VR experience

### Locomotion Systems
- **Turning Rig**: Enables user rotation in VR space
- **Teleporting Rig**: Allows instant movement to designated locations

## Locomotion Concepts

### Types of Locomotion
1. **Snap Turn**: Instant rotation by fixed angles (e.g., 30°, 45°)
   - Reduces motion sickness by avoiding smooth rotation
   - Provides quick directional changes

2. **Continuous Turn**: Smooth, gradual rotation
   - More natural feeling but can cause discomfort
   - Adjustable rotation speed

3. **Teleport**: Instant position change
   - Minimizes simulator sickness
   - Point-and-teleport interaction

### Vection and Simulator Sickness
- **Vection**: The sensation of self-motion induced by visual stimuli
- **Simulator Sickness**: Discomfort caused by mismatch between visual motion and physical stillness
- Mitigation strategies:
  - Use snap turning instead of continuous rotation
  - Implement teleportation for movement
  - Provide comfort options for users

### Teleportation Systems
- **Teleportation Areas**: Large designated zones where users can teleport freely within bounds
- **Teleportation Anchors**: Specific fixed points for precise teleportation destinations

## Hand Interaction Features

### Hand Models
- Realistic hand models for user interaction
- Visual feedback for hand presence in VR

### Grabbable Objects
- **Simple Grabbable Ball**: Basic interactable object for grasping practice
- **Grabbable Tool with Attach Point**: Advanced objects that attach to hand at defined points
- **Organized Hierarchy**: Well-structured scene hierarchy for easy management

## Grabbable GameObject Concepts

### Unity vs Real-World Scale
- Importance of maintaining consistent scale between Unity units and real-world measurements
- Standard VR scale: 1 Unity unit = 1 meter
- Affects physics calculations, reach distances, and user comfort

### Grabbable GameObject Properties
- Mass and weight distribution for realistic physics
- Rigidity and flexibility parameters
- Grip points and attach positions for realistic hand interaction

### Collision Detection Modes
VR objects use different collision detection strategies for performance and accuracy:

1. **Discrete**: Traditional collision detection
   - Checks collision at each frame
   - Lower performance impact
   - Can miss collisions in fast-moving objects

2. **Continuous**: Advanced collision detection
   - Uses swept collision tests
   - Better for fast-moving objects
   - Higher performance cost

3. **Continuous Dynamic**: Most accurate collision detection
   - Best for high-speed interactions
   - Highest performance impact
   - Recommended for critical interactive objects

### Movement Types
Different physics behaviors for VR objects:

1. **Kinematic**: Physics-based movement
   - Object responds to physics forces
   - Realistic interactions with other objects
   - Good for hand-held items

2. **Instantaneous**: Immediate position changes
   - No physics simulation
   - Teleportation-like movement
   - Useful for certain interaction patterns

3. **Velocity-Tracking**: Smooth motion following controller input
   - Tracks hand/controller velocity
   - Smooth, predictable movement
   - Prevents object rotation unwinding
