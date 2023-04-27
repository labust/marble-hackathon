# MARBLE hackathon

This is an implementation of realistic scene in Unity and vertical profiling floater. The scene covers an area of approximately 77 km^2 located around Krka estuary, while communication and controlling of the floater is established with ROS2. In order to use ROS2 inside Unity, [gRPC ROS adapter](https://github.com/MARUSimulator/grpc_ros_adapter/tree/galactic) is implemented. 

## Dependencies

* Unity 2021.3.x LTS
* ROS2

## Setup

* Clone this repository into your pc.
* After cloning, run following command to pull [marus-core](https://github.com/MARUSimulator/marus-core) submodule:
`git submodule update --init --recursive`
* Follow the instructions for building [gRPC ROS adapter](https://github.com/MARUSimulator/grpc_ros_adapter/tree/galactic)  


## Usage

* Open the scene "hackathon" in Unity (inside Assets/Scenes)
* Launch the ROS2 server: 
`ros2 launch grpc_ros_adapter ros2_server_launch.py` 
* Start the simulation in Unity (click on play button) 

### Topics

* */floater/microscope* - topic for raw image data
* */floater/volume_disp* - topic for controlling the buoyancy force


#### Examples
* Inspect published image with `rviz2`

* To publish the buoyancy force use `ros2 topic pub` command
  * Publishing `0`, will make floater to sink, while with higher values it will float
```
 ros2 topic pub /floater/volume_disp std_msgs/msg/Float32MultiArray "layout: 
 dim: []
 data_offset: 0 
 data: [50]"
  ```
