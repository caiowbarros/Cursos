namespace Exercício_de_fixação {
    class Order {
        public Date moment;
        public OrderStatus order;

        public Order(Date moment, OrderStatus order) {
            this.moment = moment;
            this.order = order;
        }

        public void addItem(OrderItem item) {

        }

        public void removeItem(OrderItem item) {

        }

        public double total() {
            return;
        }
    }
}