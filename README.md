# marble-hackathon

Unity scene for project MARBLE.

Clone the repo with submodules: git clone https://github.com/MARUSimulator/marble-hackathon.git --recursive 

#General usage 

1) Launch the server: 

ros2 launch grpc_ros_adapter ros2_server_launch.py 

2) Start the simulation in Unity (click on play button) 

3) Image is published on topic /floater/microscope, which can be shown with rviz2 

4) Control the buoyancy force on the floater by publishing data on topic /floater/volume_disp 
  
  ros2 topic pub /floater/volume_disp std_msgs/msg/Float32MultiArray "layout: 

  dim: [] 

  data_offset: 0 

  data: [50]" 

