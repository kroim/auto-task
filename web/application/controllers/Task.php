<?php
/**
 * Created by PhpStorm.
 * User: DEV-14
 * Date: 6/24/2018
 * Time: 9:14 PM
 */

defined('BASEPATH') OR exit('No direct script access allowed');
class Task extends CI_Controller{

    public function __construct()
    {
        parent::__construct();
        $this->load->helper(array('form', 'url', 'html'));
        $this->load->database();
        $this->load->model('TaskModel');
    }
    public function index(){
        echo "<h1 style='text-align: center'>No Customer</h1>";
    }
    public function autotask($id){
        $data = array();
        $data['token_id'] = $id;
        $data['task_data'] = $this->TaskModel->getTasks($id);
        $this->load->view('task', $data);
    }

    public function add_task(){
        $type = $this->input->post('type');
        if ($type == "add"){
            $retailer = $this->input->post('retailer');
            $product = serialize($this->input->post('keyword'));
            $size = $this->input->post('size');
            $color = $this->input->post('color');
            if ($color == null || $color == ""){
                $color = "random";
            }
            $category = serialize($this->input->post('category'));
            $profile = $this->input->post('profile');
            $amount = $this->input->post('amount');
            if ($amount == null || $amount == ""){
                $amount = "1";
            }
            $proxy = $this->input->post('proxy');
            if ($proxy == null || $proxy == ""){
                $proxy = "auto";
            }
            $schedule = $this->input->post('schedule');
            if ($schedule == null || $schedule == ""){
                $schedule = "manual";
            }
            $token_id = $this->input->post('token_id');
            $task_data = array(
                'retailer' => $retailer,
                'product' => $product,
                'color' => $color,
                'size' => $size,
                'category' => $category,
                'profile' => $profile,
                'amount' => $amount,
                'proxy' => $proxy,
                'schedule' => $schedule,
                'status' => "Idle",
                'token_id' => $token_id
            );
            var_dump($task_data);
            $this->TaskModel->addTasks($task_data);
            echo "success";
        }
    }
    public function edit_task(){
        $type = $this->input->post('type');
        if ($type == "edit"){
            $id = $this->input->post('id');
            $retailer = $this->input->post('retailer');
            $product = serialize($this->input->post('keyword'));
            $size = $this->input->post('size');
            $color = $this->input->post('color');
            if ($color == null || $color == ""){
                $color = "random";
            }
            $category = serialize($this->input->post('category'));
            $profile = $this->input->post('profile');
            $amount = $this->input->post('amount');
            if ($amount == null || $amount == ""){
                $amount = "1";
            }
            $proxy = $this->input->post('proxy');
            if ($proxy == null || $proxy == ""){
                $proxy = "auto";
            }
            $schedule = $this->input->post('schedule');
            if ($schedule == null || $schedule == ""){
                $schedule = "manual";
            }
            $token_id = $this->input->post('token_id');
            $task_data = array(
                'retailer' => $retailer,
                'product' => $product,
                'color' => $color,
                'size' => $size,
                'category' => $category,
                'profile' => $profile,
                'amount' => $amount,
                'proxy' => $proxy,
                'schedule' => $schedule,
                'status' => "Idle",
                'token_id' => $token_id
            );
            var_dump($task_data);
            $this->TaskModel->editTasks($id, $task_data);
            echo "success";
        }
    }
    public function remove_task(){
        $type = $this->input->post('type');
        if ($type == "remove"){
            $id = $this->input->post('id');
            $this->TaskModel->deleteTasks($id);
            echo "success";
        }
    }
    public function remove_all(){
        $type = $this->input->post('type');
        if ($type == "remove_all"){
            $token_id = $this->input->post('token_id');
            $this->TaskModel->deleteAll($token_id);
            echo "success";
        }
    }
}