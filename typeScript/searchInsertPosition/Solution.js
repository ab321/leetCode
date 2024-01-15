var numbers = [1, 3, 5, 6];
var target = 2;
console.log(searchInsert(numbers, target));
function searchInsert(nums, target) {
    if (target < nums[0]) {
        return 0;
    }
    for (var i = 0; i < nums.length; i++) {
        if (nums[i] == target) {
            return i;
        }
        else if (nums[i] < target && target < nums[i + 1]) {
            return i + 1;
        }
    }
    return nums.length;
}
;
