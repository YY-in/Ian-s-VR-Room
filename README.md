# Ian-s-VR-Room


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

## Hat Interaction System

### New Features
- **Added Hats**: Interactive hat objects that can be grabbed and manipulated
- **Hang Hats on Hooks**: Place hats on wall-mounted hooks for storage
- **Put Hats on Head**: Wear hats on the player's head in VR

### Socket Interactors
- **SocketInteractor Component**: Specialized XR interactor that holds objects at fixed positions
- Acts as snap points for objects (hooks, head mount points)
- Provides visual feedback when compatible objects are nearby
- Supports automatic snapping when objects are released near the socket
- Features:
  - Configurable interaction layer masks for selective interactions
  - Position and rotation offsets for perfect object alignment
  - Visual indicators showing socket availability
  - Automatic physics handling (kinematic when socketed)
  - Hover detection for user feedback

### Triggers to Detect Interaction
- **OnTriggerInteraction Component**: Detects when objects enter/exit trigger zones
- Supports tag and layer mask filtering for selective triggering
- Provides Unity Events for flexible integration:
  - **OnEnter**: Triggered when an object enters the trigger zone
  - **OnStay**: Triggered while an object remains in the trigger zone
  - **OnExit**: Triggered when an object leaves the trigger zone
- Includes both parameterized events (with GameObject reference) and simple events
- Useful for proximity-based interactions, zone detection, and context-aware behaviors
- Debug mode for testing and troubleshooting

### Interaction Layer Masks
- **InteractionLayerHelper**: Utility class for managing XR Interaction Toolkit layer masks
- Separates different types of interactions for cleaner logic:
  - **Hook Layer** (Layer 1): For hanging objects on wall hooks
  - **Head Layer** (Layer 2): For wearing objects on the player's head
  - **Hand Layer** (Layer 3): For grabbing and holding objects
  - **Default Layer** (Layer 0): General purpose interactions
- Prevents unwanted interactions between incompatible objects
- Allows precise control over which interactables work with which interactors
- Benefits:
  - Cleaner interaction logic and state management
  - Prevents accidental or inappropriate interactions
  - Enables context-specific behaviors (same object, different sockets)
  - Easy configuration through inspector

### Implementation Details
- **HatInteraction Script**: Manages hat-specific behaviors and state
  - Tracks current hat state (on head, on hook, in hand)
  - Dynamically switches between interaction layers based on context
  - Changes visual appearance based on state (optional material switching)
  - Handles physics automatically (kinematic when socketed, dynamic when free)
  - Supports both hook and head sockets with different behaviors
  - Clean state management and proper event handling
