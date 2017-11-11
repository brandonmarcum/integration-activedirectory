# DEFINITION - VAGRANT
Vagrant.require_version ">= 2.0.1", "< 2.1.0"
Vagrant.configure("2") do |co|

# DEFINITION - BOX
  co.vm.box = "ubuntu/xenial64"
  co.vm.box_version = "20171024.0.0"

# DEFINITION - NETWORK
  co.vm.network "forwarded_port", guest: 10000, host: 10000, host_ip: "127.0.0.1" # uix
  co.vm.network "forwarded_port", guest: 20000, host: 20000, host_ip: "127.0.0.1" # api
  co.vm.network "forwarded_port", guest: 30000, host: 30000, host_ip: "127.0.0.1" # biz
  co.vm.network "forwarded_port", guest: 40000, host: 40000, host_ip: "127.0.0.1" # dax

# DEFINITION - PROVISION
  co.vm.provision "shell", path: "Vagrantup.sh"

# DEFINITION - SYNCED FOLDER
  co.vm.synced_folder ".", "/vagrant"
end
